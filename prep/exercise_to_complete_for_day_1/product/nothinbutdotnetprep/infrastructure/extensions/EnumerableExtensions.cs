using System;
using System.Collections.Generic;

namespace nothinbutdotnetprep.infrastructure.extensions
{
    static public class EnumerableExtensions
    {
        static public IEnumerable<T> all_matching<T>(this IEnumerable<T> items,
                                                     Predicate<T> condition)
        {
            foreach (var item in items) if (condition(item)) yield return item;
        }

        public static IEnumerable<T> sort_using<T>(this IEnumerable<T> items,IComparer<T> comparer)
        {
            var list = new List<T>(items);
            list.Sort(comparer);
            return list;
        }
    }
}