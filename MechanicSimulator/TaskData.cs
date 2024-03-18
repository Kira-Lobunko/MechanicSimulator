using System;
using System.Runtime.CompilerServices;

namespace MechanicSimulator
{
    internal class TaskData
    {
        private string name;
        private int volume;
        private int weight;
        private TimeSpan duration;

        public TaskData(FixTask t)
        {
            Name = t.GetTaskName();
            Volume = t.GetVolume();
            Weight = t.GetWeight();
            Duration = t.GetDeadlineDuration();
        }

        public string Name { get => name; set => name = value; }
        public int Volume { get => volume; set => volume = value; }
        public int Weight { get => weight; set => weight = value; }
        public TimeSpan Duration { get => duration; set => duration = value; }
    }
}