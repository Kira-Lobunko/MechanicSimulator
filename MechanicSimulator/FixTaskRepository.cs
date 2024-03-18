using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicSimulator
{
    internal interface FixTaskRepository
    {
        void Add(FixTask m);
        void Clear();
        IList<FixTask> GetAll();
        void Remove(FixTask m);

    }
}
