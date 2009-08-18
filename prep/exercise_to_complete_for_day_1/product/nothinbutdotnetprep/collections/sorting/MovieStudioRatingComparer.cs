using System;
using System.Collections.Generic;

namespace nothinbutdotnetprep.collections.sorting
{
    public class MovieStudioRatingComparer : IComparer<Movie>
    {
        IDictionary<ProductionStudio, int> ratings;

        public MovieStudioRatingComparer() :this(create_default_ratings()){}

        public MovieStudioRatingComparer(IDictionary<ProductionStudio,int> ratings)
        {
            this.ratings = ratings;
        }

        static IDictionary<ProductionStudio, int> create_default_ratings()
        {
            throw new NotImplementedException();
        }

        public int Compare(Movie x, Movie y)
        {
            var val1 = lookup_movie_rating(x);
            var val2 = lookup_movie_rating(y);

           return val1.CompareTo(val2);
        }

        int lookup_movie_rating(Movie movie)
        {
            return ratings[movie.production_studio];
        }
    }
}