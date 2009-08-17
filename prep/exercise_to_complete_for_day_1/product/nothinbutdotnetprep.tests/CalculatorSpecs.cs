using developwithpassion.bdd.contexts;
using developwithpassion.bdd.mbunit;
using developwithpassion.bdd.mbunit.standard.observations;

namespace nothinbutdotnetprep.tests
{
    public class CalculatorSpecs
    {
        public abstract class concern : observations_for_a_sut_with_a_contract<Calculator,BaseCalculator> {}

        public class when_two_numbers_are_added_together : concern
        {
            because b = () =>
            {
                result = sut.add(1, 3);
            };

            it should_sum_up_the_two_numbers = () =>
            {
                result.should_be_equal_to(4);
            };

            static int result;
        }


    }
}