using System;

namespace nothinbutdotnetprep.infrastructure.searching
{
    public class NegatingCriteriaFactory<ItemToFilter, PropertyToFilterOn> :
        CriteriaFactory<ItemToFilter, PropertyToFilterOn>
    {
        CriteriaFactory<ItemToFilter, PropertyToFilterOn> factory;

        public NegatingCriteriaFactory(
            CriteriaFactory<ItemToFilter, PropertyToFilterOn> factory)
        {
            this.factory = factory;
        }

        public Criteria<ItemToFilter> equal_to(PropertyToFilterOn property_value)
        {
            return factory.equal_to(property_value).not();
        }

        public Criteria<ItemToFilter> equal_to_any(
            params PropertyToFilterOn[] property_values)
        {
            return factory.equal_to_any(property_values).not();
        }

        public CriteriaFactory<ItemToFilter, PropertyToFilterOn> not
        {
            get { return this; }
        }
    }
}