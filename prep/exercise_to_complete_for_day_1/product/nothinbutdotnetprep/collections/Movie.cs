using System;
using nothinbutdotnetprep.infrastructure.searching;

namespace nothinbutdotnetprep.collections
{
    public class Movie : IEquatable<Movie>
    {
        public string title { get; set; }
        public ProductionStudio production_studio { get; set; }
        public Genre genre { get; set; }

        public int rating { get; set; }

        public DateTime date_published { get; set; }

        public bool Equals(Movie other)
        {
            if (other == null) return false;
            return ReferenceEquals(this, other) || is_equal_to(other);
        }

        bool is_equal_to(Movie other)
        {
            return title.Equals(other.title);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Movie);
        }

        public override int GetHashCode()
        {
            return title.GetHashCode();
        }

        public delegate bool OurMatcher<T>(T item);


        static public Criteria<Movie> was_published_after_or_by(DateTime date,ProductionStudio studio)
        {
            return is_published_by(studio).or(was_published_after(date));
        }

        static public Criteria<Movie> was_published_after(DateTime date)
        {
            return new IsPublishedAfter(date);
        }

        static public Criteria<Movie> is_published_by_disney()
        {
            return is_published_by(ProductionStudio.Disney);
        }

        static public Criteria<Movie> is_published_by(ProductionStudio studio) {
            return new IsPublishedBy(studio);
        }