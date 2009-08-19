using System.Collections.Generic;
using developwithpassion.bdd.contexts;
using developwithpassion.bdd.mbunit.standard.observations;
using developwithpassion.bdddoc.core;
using developwithpassion.bdd.mbunit;
using nothinbutdotnetstore.infrastructure;
using nothinbutdotnetstore.tests.utility;
using System.Linq;

namespace nothinbutdotnetstore.tests.infrastructure
{
    public class EnumerableExtensionsSpecs
    {
        public abstract class concern : observations_for_a_static_sut {}

        [Concern(typeof (EnumerableExtensions))]
        public class when_performing_an_action_against_every_item_in_the_set : concern
        {
            context c = () => {
                                  numbers =
                                      ObjectMother.create_enumerable_from(1, 2,
                                                                          5, 3,
                                                                          6);

            };

            because b = () => {
                EnumerableExtensions.each(numbers, number => number_of_items_invoked_against++);
            };


            it should_perform_the_action_against_each_item_in_the_set = () =>
            {
                number_of_items_invoked_against.should_be_equal_to(numbers.Count());
            };

            static int result;
            static IEnumerable<int> numbers;
            static int number_of_items_invoked_against;
        }
    }
}
