using System;
using System.Collections.Generic;

namespace nothinbutdotnetprep.infrastructure.sorting
{
    public class PropertyComparer<ItemToSort,PropertyToSortOn> : IComparer<ItemToSort> where PropertyToSortOn : IComparable<PropertyToSortOn>
    {
        Func<ItemToSort, PropertyToSortOn> accessor;

        public PropertyComparer(Func<ItemToSort, PropertyToSortOn> accessor)
        {
            this.accessor = accessor;
        }

        public int Compare(ItemToSort x, ItemToSort y)
        {
            return accessor(x).CompareTo(accessor(y));
        }
    }
}