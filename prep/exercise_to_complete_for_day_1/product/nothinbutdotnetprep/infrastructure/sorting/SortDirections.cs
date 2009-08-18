namespace nothinbutdotnetprep.infrastructure.sorting
{
    public class SortDirections
    {
        static public SortDirection ascending = new AscendingSortDirection();
        public static SortDirection descending = new DescendingSortDirection();
    }
}