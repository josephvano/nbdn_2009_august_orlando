using System;

namespace nothinbutdotnetprep.infrastructure.searching
{
    public class PropertyCriteria<ItemToFilter,PropertyToFilterOn> : Criteria<ItemToFilter>
    {
        Criteria<PropertyToFilterOn> regular_criteria;
        Func<ItemToFilter, PropertyToFilterOn> accessor;

        public PropertyCriteria(Criteria<PropertyToFilterOn> regular_criteria, Func<ItemToFilter, PropertyToFilterOn> accessor)
        {
            this.regular_criteria = regular_criteria;
            this.accessor = accessor;
        }

        public bool is_satisfied_by(ItemToFilter item)
        {
            return regular_criteria.is_satisfied_by(accessor(item));
        }
    }
}