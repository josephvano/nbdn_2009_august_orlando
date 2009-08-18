using System.Collections.Generic;

namespace nothinbutdotnetprep.infrastructure.sorting
{
    public class DescendingSortDirection : SortDirection
    {
        public IComparer<T> apply_to<T>(IComparer<T> comparer)
        {
            return comparer.reverse();
        }
    }
}