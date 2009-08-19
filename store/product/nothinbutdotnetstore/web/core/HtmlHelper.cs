using System;
using System.Collections.Generic;

namespace nothinbutdotnetstore.web.core
{
    public static class HtmlHelper
    {
        static public void list<T>(this IEnumerable<T> list, Action<T>func)
        {
            foreach (var item in list) {
                func(item);
            }
        }
    }
}