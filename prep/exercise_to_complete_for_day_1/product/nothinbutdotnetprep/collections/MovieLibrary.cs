using System;
using System.Collections.Generic;
using nothinbutdotnetprep.infrastructure.extensions;
using nothinbutdotnetprep.infrastructure.searching;

namespace nothinbutdotnetprep.collections
{
    public class MovieLibrary
    {
        IList<Movie> list_of_movies;

        public MovieLibrary(IList<Movie> list_of_movies)
        {
            this.list_of_movies = list_of_movies;
        }

        public IEnumerable<Movie> sort_movies(IComparer<Movie> comparer)
        {
            return list_of_movies.sort_using(comparer);
        }


        public IEnumerable<Movie> filter_movies(Criteria<Movie> criteria)
        {
            return list_of_movies.all_matching(criteria.is_satisfied_by);
        }

        public IEnumerable<Movie> all_movies()
        {
            return list_of_movies.one_at_a_time();
        }

        public void add(Movie movie)
        {
            if (already_contains(movie)) return;
            list_of_movies.Add(movie);
        }

        bool already_contains(Movie movie)
        {
            return list_of_movies.Contains(movie);
        }

        static public Predicate<Movie> is_published_after(DateTime date)
        {
            return movie => movie.date_published > date;
        }

        static public Predicate<Movie> is_published_by(ProductionStudio studio)
        {
            return new IsPublishedBy(studio).is_satisfied_by;
        }
    }
}