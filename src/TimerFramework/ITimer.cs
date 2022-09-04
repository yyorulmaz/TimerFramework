using System;

namespace TimerFramework
{
    internal interface ITimer
    {
        Guid InstanceId { get; }
        event Action<TimerModel> Receive;

        TimerModel Get(Guid timerId);
        bool Add(TimerModel timer);
        bool Remove(Guid timerId);
        bool Remove(TimerModel timer);
        bool Update(TimerModel timer);
        void SetReceive(TimerModel timer);
    }
}
