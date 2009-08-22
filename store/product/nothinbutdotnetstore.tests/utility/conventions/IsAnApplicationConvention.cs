using System;
using nothinbutdotnetstore.infrastructure;

namespace nothinbutdotnetstore.tests.utility.conventions
{
    public class IsAnApplicationConvention : Criteria<Type>
    {
        public bool is_satisfied_by(Type item)
        {
            return typeof (ApplicationConvention).IsAssignableFrom(item)
                   && !item.IsAbstract
                   && item.IsClass;
        }
    }
}