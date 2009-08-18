using System;

namespace nothinbutdotnetprep.events
{
    public class AlarmRangInformation
    {
        public DateTime time_the_alarm_rang { get; private set; }

        public AlarmRangInformation(DateTime time_the_alarm_rang)
        {
            this.time_the_alarm_rang = time_the_alarm_rang;
        }
    }
}