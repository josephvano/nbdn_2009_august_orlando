using System;
using System.Collections.Generic;

namespace nothinbutdotnetprep.collections.sorting
{
    public class TitleAscSort : IComparer<Movie>
    {
        public int Compare(Movie x, Movie y)
        {
            return x.title.CompareTo(y.title); 
        }
    }
}