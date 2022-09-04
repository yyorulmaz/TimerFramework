using System;

namespace TimerFramework
{
    public class TimerFactory
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
