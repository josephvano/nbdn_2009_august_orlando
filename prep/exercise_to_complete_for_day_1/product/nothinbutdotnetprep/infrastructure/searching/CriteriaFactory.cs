namespace nothinbutdotnetprep.infrastructure.searching
{
    public interface CriteriaFactory<TItemToFilterOn, TPropertyByWhichToFilter>
    {
        Criteria<TItemToFilterOn> equal_to(
            TPropertyByWhichToFilter property_value);

        Criteria<TItemToFilterOn> equal_to_any(
            params TPropertyByWhichToFilter[] property_values);

        CriteriaFactory<TItemToFilterOn, TPropertyByWhichToFilter> not { get; }
    }
}