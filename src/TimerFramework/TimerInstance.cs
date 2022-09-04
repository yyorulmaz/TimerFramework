using System;
using System.Collections.Concurrent;

namespace TimerFramework
{
    internal class TimerInstance
    {
        internal static ConcurrentDictionary<Guid, ITimer> Instances = new ConcurrentDictionary<Guid, ITimer>();
    }
}
