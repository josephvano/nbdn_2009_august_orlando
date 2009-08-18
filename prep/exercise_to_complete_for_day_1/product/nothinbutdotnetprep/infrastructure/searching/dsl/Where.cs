using System;

namespace nothinbutdotnetprep.infrastructure.searching.dsl
{
    public class Where<TItemToFilter>
    {
        static public CriteriaFactory<TItemToFilter, TPropertyOnWhichToFilter>
            has_a<TPropertyOnWhichToFilter>
            (Func<TItemToFilter, TPropertyOnWhichToFilter>
                 property_on_which_to_filter)
        {
            return
                new BasicCriteriaFactory
                    <TItemToFilter, TPropertyOnWhichToFilter>(
                    property_on_which_to_filter);
        }

        //static public void has_an<TPropertyTypeToFilterOn>
        //    (Func<TItemToFilter, TPropertyTypeToFilterOn> func)
        //{
        //    throw new NotImplementedException();
        //}
        static public Criteria<TItemToFilter> has_value_equal_to
            <TPropertyOnWhichToFilter>(
            Func<TItemToFilter, TPropertyOnWhichToFilter> accessor,
            TPropertyOnWhichToFilter value_to_match) {

            return new AnonymousCriteria<TItemToFilter>(
                item => accessor(item).Equals(value_to_match));
        }
    }
}