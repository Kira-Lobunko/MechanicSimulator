using System;

namespace MechanicSimulator
{
    internal class SimulationConfigs
    {

        public SimulationConfigs() { }

        private DateTime simulationBegin;
        private TimeSpan simulationDuration;
        private TimeSpan simulationStep;
        private int taskFlowCapacity;
        private double updateFrequency;

        public DateTime SimulationBegin { get => simulationBegin; set => simulationBegin = value; }
        public TimeSpan SimulationDuration { get => simulationDuration; set => simulationDuration = value; }
        public TimeSpan SimulationStep { get => simulationStep; set => simulationStep = value; }
        public int TaskFlowCapacity { get => taskFlowCapacity; set => taskFlowCapacity = value; }
        public double UpdateFrequency { get => updateFrequency; set => updateFrequency = value; }
    }
}
