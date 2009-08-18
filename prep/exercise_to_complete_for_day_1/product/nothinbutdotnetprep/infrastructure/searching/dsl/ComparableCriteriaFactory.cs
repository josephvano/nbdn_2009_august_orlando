using System;
using nothinbutdotnetprep.infrastructure.ranges;

namespace nothinbutdotnetprep.infrastructure.searching.dsl
{
    public interface ComparableCriteriaFactory<ItemToFilter, PropertyToFilterOn>  : CriteriaFactory<ItemToFilter,PropertyToFilterOn> where PropertyToFilterOn : IComparable<PropertyToFilterOn>{

        Criteria<ItemToFilter> is_greater_than(PropertyToFilterOn value);
        Criteria<ItemToFilter> is_less_than(PropertyToFilterOn value);
        Criteria<ItemToFilter> falls_in(PropertyToFilterOn start,PropertyToFilterOn end);
        Criteria<ItemToFilter> falls_in(Range<PropertyToFilterOn> range);

    }
}