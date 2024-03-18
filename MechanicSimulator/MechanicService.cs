using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicSimulator
{
    internal interface MechanicService
    {
        /// <summary>
        /// 
        /// </summary>
        void ExecuteStep();
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        DateTime GetCurrentDateTime();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IList<MechanicStat> GetMechanicStats();
    }
}
