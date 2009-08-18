using System;

namespace nothinbutdotnetprep.infrastructure.searching
{
    public class BasicCriteriaFactory<ItemToFilter,PropertyToFilterOn> : CriteriaFactory<ItemToFilter,PropertyToFilterOn>
    {
        Func<ItemToFilter, PropertyToFilterOn> property_accessor;

        public BasicCriteriaFactory(Func<ItemToFilter, PropertyToFilterOn> property_accessor)
        {
            this.property_accessor = property_accessor;
        }

        public Criteria<ItemToFilter> equal_to(PropertyToFilterOn expected_value)
        {
            return new PropertyCriteria<ItemToFilter, PropertyToFilterOn>(
                new EqualToCriteria<PropertyToFilterOn>(expected_value),
                property_accessor);
        }

        public Criteria<ItemToFilter> equal_to_any(params PropertyToFilterOn[] property_values)
        {
            throw new NotImplementedException();
        }

        public CriteriaFactory<ItemToFilter, PropertyToFilterOn> not
        {
            get {
                return
                    new NegatingCriteriaFactory
                        <ItemToFilter, PropertyToFilterOn>(this);}
        }

        public Criteria<ItemToFilter> not_equal_to(PropertyToFilterOn property_value)
        {
            return equal_to(property_value).not();
        }
    }
}