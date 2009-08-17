using System;
using System.Collections;
using System.Collections.Generic;
using nothinbutdotnetprep.infrastructure.extensions;

namespace nothinbutdotnetprep.collections
{
    public class EnumerableList<T> : IEnumerable<T>
    {
        IList<T> items;

        public EnumerableList(IList<T> items)
        {
            this.items = items;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }
    }

    public class MovieLibrary
    {
        IList<Movie> list_of_movies;

        public MovieLibrary(IList<Movie> list_of_movies)
        {
            this.list_of_movies = list_of_movies;
        }

        public IEnumerable<Movie> sort_movies(IComparer<Movie> by_sort_method) {

            var lst = new List<Movie>(list_of_movies);
            lst.Sort(by_sort_method);

            foreach(var movie in lst)
            {
                yield return movie;
            }
        }

        public IEnumerable<Movie> filter_movies(Predicate<Movie> by_specificaiton) {

            foreach (var m in this.list_of_movies)
            {
                if (by_specificaiton(m)) yield return m;
            }
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

        public IEnumerable<Movie> sort_all_movies_by_title_descending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_movies_published_by_pixar()
        {
            foreach (var m in this.list_of_movies) {
                if (m.production_studio.Equals(ProductionStudio.Pixar))
                    yield return m;
            }
        }

        public IEnumerable<Movie> all_movies_published_by_pixar_or_disney()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_title_ascending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_movie_studio_and_year_published()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_movies_not_published_by_pixar()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_movies_published_after(int year)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_movies_published_between_years(int startingYear, int endingYear)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_kid_movies()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> all_action_movies()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_date_published_descending()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> sort_all_movies_by_date_published_ascending()
        {
            throw new NotImplementedException();
        }

    }
}