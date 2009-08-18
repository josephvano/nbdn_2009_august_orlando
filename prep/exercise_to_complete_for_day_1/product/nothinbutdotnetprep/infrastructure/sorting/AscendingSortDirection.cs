using System;
using System.Collections.Generic;

namespace nothinbutdotnetprep.infrastructure.sorting
{
    public class AscendingSortDirection : SortDirection
    {
        public IComparer<T> apply_to<T>(IComparer<T> comparer)
        {
            return comparer;
        }
    }
}