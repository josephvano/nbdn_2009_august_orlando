using System;
using developwithpassion.bdd.contexts;
using developwithpassion.bdd.mbunit.standard.observations;
using developwithpassion.bdddoc.core;
using nothinbutdotnetprep.events;
using nothinbutdotnetprep.infrastructure.events;

namespace nothinbutdotnetprep.tests.events
{
    public class AlarmClockSpecs
    {
        public abstract class concern :
            observations_for_a_sut_without_a_contract<AlarmClock> {}

        [Concern(typeof (AlarmClock))]
        public class when_the_alarm_rings : concern
        {
            after_the_sut_has_been_created ac = () =>
            {
                sut.ring += (e) => our_event_information = e;
            };

            because b = () =>
            {
                sut.ring_the_alarm();
            };


            it should_raise_an_event_that_provides_event_specific_information =
                () => {
                

                };

            static OurEventArgs<AlarmClock, DateTime> our_event_information;
        }
    }
}