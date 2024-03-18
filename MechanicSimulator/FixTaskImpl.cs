using Newtonsoft.Json;
using System;

namespace MechanicSimulator
{
    internal class FixTaskImpl : FixTask
    {
        public FixTaskImpl() { }
        public FixTaskImpl(string taskName, int volume, int weight, TimeSpan deadlineDuration) 
        {
            _name = taskName;
            _volume = volume;
            _deadlineDuration = deadlineDuration;
            _isHandled = false;
            _weight = weight;
        }

        public string GetTaskName()
        {
            return _name;
        }

        public int GetWeight()
        {
            return _weight;        
        }

        public FixTaskImpl(FixTask other, DateTime createdAt)
        { 
            _volume = other.GetVolume();
            _createDateTime = createdAt;
            _deadlineDuration = other.GetDeadlineDuration();
            _isHandled = false;
        }
        public DateTime GetCreateDateTime()
        {
            return _createDateTime;
        }

        public TimeSpan GetDeadlineDuration()
        {
            return _deadlineDuration;
        }

        public int GetVolume()
        {
            return _volume;
        }

        public DateTime HandledAt()
        {
            return _handledAt;
        }

        public bool IsHandled()
        {
            return _isHandled;
        }

        public void Handle(DateTime current)
        {
            _handledAt = current;
            _isHandled = true;
        }

        public void HandlePart(int volume)
        {
            _volume -= volume;
        }

        [JsonProperty]
        private int _volume;
        [JsonProperty]
        private string _name;
        [JsonProperty]
        private int _weight;
        [JsonProperty]
        private TimeSpan _deadlineDuration;

        private DateTime _createDateTime;
        private bool _isHandled;
        private DateTime _handledAt;
    }
}