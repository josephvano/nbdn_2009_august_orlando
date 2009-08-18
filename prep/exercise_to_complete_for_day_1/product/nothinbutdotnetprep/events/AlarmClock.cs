using System;
using nothinbutdotnetprep.infrastructure.events;

namespace nothinbutdotnetprep.events
{
    public class AlarmClock
    {
        public void ring_the_alarm()
        {
            ring(new OurEventArgs<AlarmClock, DateTime>(this, DateTime.Now));
        }

        public event OurEventHandler<AlarmClock, DateTime> ring =
            delegate {};
    }
}