using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MechanicSimulator
{
    internal class FixTaskFlowImpl : FixTasksFlow
    {
        public IList<FixTask> GenerateFixTasks(DateTime begin, TimeSpan duration, int totalCount, IList<FixTask> weightedTasks)
        {
            if (weightedTasks.Count <= 0)
            {
                MessageBox.Show("Невозможно сгенерировать поток заявок - нет данных о базовых заявках. Добавьте базовые задачи в таблицу.", "Зависимость по данным", MessageBoxButtons.OK);
                throw new ArgumentException();
            }
 
            var step = duration.TotalMinutes / totalCount;

            IList<FixTask> tasks = new List<FixTask>();
            for (int i = 0; i < totalCount; i++)
            {
                FixTask task = new FixTaskImpl(GetRandomTask(weightedTasks), begin.Add(TimeSpan.FromMinutes(step * i)));
                tasks.Add(task);
            }

            return tasks;
        }

        private FixTask GetRandomTask(IList<FixTask> weightedTasks)
        {
            double totalWeight = weightedTasks.Sum(task => task.GetWeight());
            
            double random = new Random().NextDouble();
            double leftLimit = 0.0;
            double rightLimit = 0.0;

            foreach (var t in weightedTasks)
            {
                // Normalize taskWeight
                rightLimit += (double)t.GetWeight() / totalWeight;
                if (leftLimit < random && random < rightLimit)
                { 
                    return t;
                }

                leftLimit = rightLimit;
            }

            return null;
        }        
    }
}
