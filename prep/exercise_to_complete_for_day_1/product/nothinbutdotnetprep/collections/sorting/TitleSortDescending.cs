using System.Collections.Generic;

namespace nothinbutdotnetprep.collections.sorting
{
    public class TitleSortDescending : IComparer<Movie>
    {
        public int Compare(Movie x, Movie y)
        {
            return y.title.CompareTo(x.title); 
        }
    }
}