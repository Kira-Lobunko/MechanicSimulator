using System;
using System.Collections.Generic;

namespace MechanicSimulator
{
    public interface Mechanic
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string GetName();
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IList<FixTask> GetAllTasks();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int GetQueueLenLimit();

        /// <summary>
        /// 
        /// </summary>
        void UpdateDateTime(DateTime current);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tasks"></param>
        void SetTaskProvider(ref IList<FixTask> tasks);
    }

}
