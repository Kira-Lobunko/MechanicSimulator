using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MechanicSimulator
{
    internal class MechanicServiceImpl : MechanicService
    {
        public MechanicServiceImpl(SimulationConfigs simulationConfigs, IList<FixTask> baseWeightedTasks, IList<Mechanic> mechanics)
        {
            if (mechanics.Count <= 0)
            {
                MessageBox.Show("Невозможно запустить симуляцию работы сервиса без механиков. Добавьте механиков в таблицу.", "Зависимость по данным", MessageBoxButtons.OK);
                throw new ArgumentException();
            }

            this.simulationConfigs = simulationConfigs;
            this.mechanics = mechanics;

            baseTasks = baseWeightedTasks;
            currentDateTime = simulationConfigs.SimulationBegin;

            try
            {
                tasks = flow.GenerateFixTasks(simulationConfigs.SimulationBegin, simulationConfigs.SimulationDuration, simulationConfigs.TaskFlowCapacity, this.baseTasks);
                foreach (var m in this.mechanics)
                {
                    m.SetTaskProvider(ref tasks);
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExecuteStep()
        {
            currentDateTime = currentDateTime.Add(simulationConfigs.SimulationStep);
            if (currentDateTime >= simulationConfigs.SimulationBegin.Add(simulationConfigs.SimulationDuration))
            {                
                throw new Exception();
            }

            if (tasks.Count <= 0)
            {
                throw new Exception();
            }

            foreach (var mechanic in mechanics)
            {
                mechanic.UpdateDateTime(currentDateTime);
            }
        }

        public IList<MechanicStat> GetMechanicStats()
        {
            return mechanics.Select(m => new MechanicStat(m, currentDateTime)).ToList();
        }

        public DateTime GetCurrentDateTime()
        {
            return currentDateTime;
        }

        private DateTime currentDateTime;
        private SimulationConfigs simulationConfigs;
        private IList<Mechanic> mechanics = new List<Mechanic>();
        private IList<FixTask> baseTasks = new List<FixTask>();
        private IList<FixTask> tasks = new List<FixTask>();
        private FixTasksFlow flow = new FixTaskFlowImpl();
    }
}
