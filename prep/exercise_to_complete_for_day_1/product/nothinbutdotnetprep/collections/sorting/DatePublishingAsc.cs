namespace nothinbutdotnetprep.collections.sorting
{
    public class DatePublishingAsc : MovieComparer
    {
        public int Compare(Movie x, Movie y)
        {
            return x.date_published.CompareTo(y.date_published);
        }
    }
}