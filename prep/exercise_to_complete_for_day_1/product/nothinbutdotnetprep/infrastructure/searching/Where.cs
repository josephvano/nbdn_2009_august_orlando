using System;

namespace nothinbutdotnetprep.infrastructure.searching
{
    public class Where<TItemToFilter>
    {
        static public ICriteriaFactory<TItemToFilter, TPropertyOnWhichToFilter> 
            has_a<TPropertyOnWhichToFilter>
            (Func<TItemToFilter, TPropertyOnWhichToFilter> propertyOnWhichToFilter)
        {
            throw new NotImplementedException();
        }
        //static public void has_an<TPropertyTypeToFilterOn>
        //    (Func<TItemToFilter, TPropertyTypeToFilterOn> func)
        //{
        //    throw new NotImplementedException();
        //}
    }

    public interface ICriteriaFactory<TItemToFilterOn, TPropertyByWhichToFilter>
    {
        Criteria<TItemToFilterOn> equal_to(TPropertyByWhichToFilter property_value);
        Criteria<TItemToFilterOn> equal_to_any(params TPropertyByWhichToFilter[] property_values);
        Criteria<TItemToFilterOn> not_equal_to(TPropertyByWhichToFilter property_value);
        Criteria<TItemToFilterOn> greater_than(TPropertyByWhichToFilter property_value);
        Criteria<TItemToFilterOn> less_than(TPropertyByWhichToFilter property_value);
    }
}