using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MechanicSimulator
{
    internal class MechanicImpl : Mechanic
    {
        public MechanicImpl() { }
        public MechanicImpl(string name, int queueLenLimit, DateTime current)
        { 
            _name = name;
            _currentDateTime = current;
            _queueLenLimit = queueLenLimit;
        }

        public IList<FixTask> GetAllTasks()
        {
            return _queue.ToList();
        }

        public string GetName()
        {
            return _name;
        }

        public int GetQueueLenLimit()
        {
            return _queueLenLimit;
        }

        public void UpdateDateTime(DateTime current)
        {
            int volume = (int)(current - _currentDateTime).TotalMinutes;
            
            while (volume > 0)
            {
                if (_queue.Count(t => !t.IsHandled()) <= 0)
                {
                    while (_queue.Count(t => !t.IsHandled()) < _queueLenLimit && tasksProvider.Count > 0 && tasksProvider[0].GetCreateDateTime() < _currentDateTime)
                    {
                        _queue.Add(tasksProvider[0]);
                        tasksProvider.RemoveAt(0);
                    }
                }

                try
                {
                    var currTask = _queue.First(t => !t.IsHandled());
                    if (currTask.GetVolume() < volume)
                    {
                        currTask.Handle(_currentDateTime);
                        volume -= currTask.GetVolume();
                        _currentDateTime = _currentDateTime.AddMinutes(currTask.GetVolume());
                    }
                    else
                    {
                        _currentDateTime = _currentDateTime.AddMinutes(volume);
                        currTask.HandlePart(volume);
                        volume = 0;
                    }
                }
                catch
                {
                    _currentDateTime = current;
                    return;
                }
            }
        }

        public void SetTaskProvider(ref IList<FixTask> tasks)
        {
            tasksProvider = tasks;
            tasksProvider.OrderBy(t => t.GetCreateDateTime());
        }

        [JsonProperty]
        private string _name = "";
        [JsonProperty]
        private int _queueLenLimit = 0;

        private IList<FixTask> _queue = new List<FixTask>();
        private IList<FixTask> tasksProvider;
        private DateTime _currentDateTime = DateTime.MinValue;
    }
}
