using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicSimulator
{
    public class MechanicData
    {
        public MechanicData(Mechanic mechanic) 
        {
            fullName = mechanic.GetName();
            qLimit = mechanic.GetQueueLenLimit();
        }

        private string fullName;
        private int qLimit;

        public string FullName { get => fullName; set => fullName = value; }
        public int QLimit { get => qLimit; set => qLimit = value; }
    }
}
