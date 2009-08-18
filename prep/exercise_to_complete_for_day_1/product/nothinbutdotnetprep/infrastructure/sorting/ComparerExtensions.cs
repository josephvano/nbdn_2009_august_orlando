using System.Collections.Generic;

namespace nothinbutdotnetprep.infrastructure.sorting
{
    static public class ComparerExtensions
    {
        static public IComparer<T> followed_by<T>(this IComparer<T> first,
                                           IComparer<T> second)
        {
            return new ChainedComparer<T>(first, second);
        }

        static public IComparer<T> reverse<T>(this IComparer<T> first)
                                       
        {
            return new ReverseComparer<T>(first);
        }
    }
}