using System;
using System.Collections.Generic;

namespace MechanicSimulator
{
    internal interface FixTasksFlow
    {
        IList<FixTask> GenerateFixTasks(DateTime begin, TimeSpan step, int totalCount, IList<FixTask> weightedTasks);
    }
}
