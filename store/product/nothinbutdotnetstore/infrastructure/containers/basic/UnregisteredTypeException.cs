using System;

namespace nothinbutdotnetstore.infrastructure.containers.basic
{
    public class UnregisteredTypeException : Exception
    {
        public Type type_that_has_no_resolver_registered { get; private set; }

        public UnregisteredTypeException(Type type_that_is_not_registered)
        {
            this.type_that_has_no_resolver_registered = type_that_is_not_registered;
        }
    }
}