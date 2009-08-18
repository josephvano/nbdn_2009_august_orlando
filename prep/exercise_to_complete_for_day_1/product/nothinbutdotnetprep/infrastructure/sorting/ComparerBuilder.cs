using System;
using System.Collections.Generic;

namespace nothinbutdotnetprep.infrastructure.sorting
{
    public class ComparerBuilder<ItemToSort> : IComparer<ItemToSort>
    {
        IComparer<ItemToSort> final_comparer;

        public ComparerBuilder(IComparer<ItemToSort> initial_comparer)
        {
            final_comparer = initial_comparer;
        }

        public int Compare(ItemToSort x, ItemToSort y)
        {
            return final_comparer.Compare(x, y);
        }

        public ComparerBuilder<ItemToSort> then_by<PropertyToSortOn>(
            Func<ItemToSort, PropertyToSortOn> func)
            where PropertyToSortOn : IComparable<PropertyToSortOn>
        {
            return
                then_using(
                    new PropertyComparer<ItemToSort, PropertyToSortOn>(func));
        }

        public ComparerBuilder<ItemToSort> then_by_descending<PropertyToSortOn>(
            Func<ItemToSort, PropertyToSortOn> func)
            where PropertyToSortOn : IComparable<PropertyToSortOn>
        {
            return
                then_using(
                    new PropertyComparer<ItemToSort, PropertyToSortOn>(func).
                        reverse());
        }

        public ComparerBuilder<ItemToSort> then_using(
            IComparer<ItemToSort> comparer)
        {
            final_comparer = final_comparer.followed_by(comparer);
            return this;
        }
    }
}