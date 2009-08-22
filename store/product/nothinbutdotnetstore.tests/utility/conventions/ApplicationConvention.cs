using System;
using nothinbutdotnetstore.infrastructure;

namespace nothinbutdotnetstore.tests.utility.conventions
{
    public interface ApplicationConvention: Criteria<Type>
    {
        bool applies_to(Type type);
    }
}