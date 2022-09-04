using System;

namespace TimerFramework
{
    internal class TimerFactory
    {
        public ITimer CreateTimer()
        {
           var instanceId = Guid.NewGuid();
            ITimer timer = new Timer(instanceId);

            TimerInstance.Instances.TryAdd(instanceId, timer);

            return timer;
        }
    }
}
