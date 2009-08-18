using System;

namespace nothinbutdotnetprep.infrastructure.searching
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
    }
}