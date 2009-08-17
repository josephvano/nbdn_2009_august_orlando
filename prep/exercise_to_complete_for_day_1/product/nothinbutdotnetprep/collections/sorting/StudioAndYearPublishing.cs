namespace nothinbutdotnetprep.collections.sorting
{
    public class StudioAndYearPublishing : MovieComparer
    {
        public StudioAndYearPublishing()
        {
        }

        public int Compare(Movie x, Movie y)
        {
            var val1 = lookup_movie_rating(x);
            var val2 = lookup_movie_rating(y);

           return val1.CompareTo(val2);
        }

        int lookup_movie_rating(Movie movie)
        {
            if (movie.production_studio == ProductionStudio.MGM)
                return 1;

            if (movie.production_studio == ProductionStudio.Pixar)
                return 2;

            if (movie.production_studio == ProductionStudio.Dreamworks)
                return 3;

            if (movie.production_studio == ProductionStudio.Universal)
                return 4;

            if (movie.production_studio == ProductionStudio.Disney)
                return 5;

            return 6;
        }
    }
}