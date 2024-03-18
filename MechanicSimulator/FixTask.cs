using System;

namespace MechanicSimulator
{
    public interface FixTask
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string GetTaskName();
        
        /// <summary>
        /// Объём работы в условных единицах.
        /// </summary>
        int GetVolume();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int GetWeight();
        
        /// <summary>
        /// 
        /// </summary>
        void Handle(DateTime current);
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        bool IsHandled();

        /// <summary>
        /// 
        /// </summary>
        DateTime GetCreateDateTime();

        TimeSpan GetDeadlineDuration();

        DateTime HandledAt();
        void HandlePart(int volume);
    }
}
