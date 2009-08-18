namespace nothinbutdotnetprep.infrastructure.searching
{
    public class EqualToCriteria<T> : Criteria<T>
    {
        T specified_value;

        public EqualToCriteria(T value_to_equal)
        {
            this.specified_value = value_to_equal;
        }

        public bool is_satisfied_by(T item)
        {
            return item.Equals(specified_value);
        }
    }
}