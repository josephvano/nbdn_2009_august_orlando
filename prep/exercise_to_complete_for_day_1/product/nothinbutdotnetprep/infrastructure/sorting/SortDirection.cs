using System.Collections.Generic;

namespace nothinbutdotnetprep.infrastructure.sorting
{
    public interface SortDirection
    {
        IComparer<T> apply_to<T>(IComparer<T> comparer); 
    }
}