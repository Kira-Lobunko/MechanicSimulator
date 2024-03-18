using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanicSimulator
{
    internal interface MechanicRepository
    {
        void Add(Mechanic m);
        void Clear();
        IList<Mechanic> GetAll();
        void Remove(Mechanic m);
    }
}
