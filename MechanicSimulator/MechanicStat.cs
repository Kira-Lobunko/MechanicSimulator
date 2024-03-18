
using System;
using System.Linq;

namespace MechanicSimulator
{
    public class MechanicStat
    {
        private int totalRequestsAmount;
        private int handledRequestsAmount;
        private int delayedRequestsAmount;

        private int queuedRequestsAmount;
        private int limitRequestsAmount;
        private string mechanicName;

        public MechanicStat(Mechanic mechanic, DateTime current)
        {
            mechanicName = mechanic.GetName();
            limitRequestsAmount = mechanic.GetQueueLenLimit();
            totalRequestsAmount = mechanic.GetAllTasks().Count;
            queuedRequestsAmount = mechanic.GetAllTasks().Count(t => t.IsHandled() == false);
            handledRequestsAmount = mechanic.GetAllTasks().Count(t => t.IsHandled() == true);
            delayedRequestsAmount = mechanic.GetAllTasks().Count(t => t.GetCreateDateTime().Add(t.GetDeadlineDuration()) < t.HandledAt());
        }

        public int TotalRequestsAmount { get => totalRequestsAmount; set => totalRequestsAmount = value; }
        public int HandledRequestsAmount { get => handledRequestsAmount; set => handledRequestsAmount = value; }
        public int DelayedRequestsAmount { get => delayedRequestsAmount; set => delayedRequestsAmount = value; }
        public int QueuedRequestsAmount { get => queuedRequestsAmount; set => queuedRequestsAmount = value; }
        public string MechanicName { get => mechanicName; set => mechanicName = value; }
        public int LimitRequestsAmount { get => limitRequestsAmount; set => limitRequestsAmount = value; }
    }
}
