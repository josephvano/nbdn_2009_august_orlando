using System;
using System.Collections.Generic;

namespace nothinbutdotnetprep.infrastructure.sorting
{
    public class Sort<ItemToSort>
    {
        static public ComparerBuilder<ItemToSort> by<PropertyToSortOn>(
            Func<ItemToSort, PropertyToSortOn> func
            ) where PropertyToSortOn : IComparable<PropertyToSortOn>
        {
            return by(func, SortDirections.ascending);
        }

        static public ComparerBuilder<ItemToSort> by<PropertyToSortOn>(
            Func<ItemToSort, PropertyToSortOn> func,
            SortDirection sort_direction)
            where PropertyToSortOn : IComparable<PropertyToSortOn>
        {
            return
                with(
                    sort_direction.apply_to(
                        new PropertyComparer<ItemToSort, PropertyToSortOn>(func)));
        }

        static public ComparerBuilder<ItemToSort> with(
            IComparer<ItemToSort> comparer)
        {
            return new ComparerBuilder<ItemToSort>(comparer);
        }
    }
}