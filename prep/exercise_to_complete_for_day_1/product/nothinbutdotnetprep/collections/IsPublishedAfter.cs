using System;
using nothinbutdotnetprep.infrastructure.searching;

namespace nothinbutdotnetprep.collections
{
    public class IsPublishedAfter : Criteria<Movie>
    {
        DateTime date;

        public IsPublishedAfter(DateTime date)
        {
            this.date = date;
        }

        public bool is_satisfied_by(Movie item)
        {
            return item.date_published > date;
        }
    }
}