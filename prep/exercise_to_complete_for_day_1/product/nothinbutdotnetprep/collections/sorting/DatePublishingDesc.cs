namespace nothinbutdotnetprep.collections.sorting
{
    public class DatePublishingDesc : MovieComparer
    {
        public int Compare(Movie x, Movie y)
        {
            return y.date_published.CompareTo(x.date_published);
        }
    }
}