using System;

namespace nothinbutdotnetstore.infrastructure.containers.basic
{
    public class UnregisteredTypeException : Exception
    {
        readonly Type type_that_is_not_registered;

        public UnregisteredTypeException(Type type_that_is_not_registered)
        {
            this.type_that_is_not_registered = type_that_is_not_registered;
        }

        public override string Message
        {
            get
            {
                return string.Format("There is no registered resolver for an object of type {0}",
                    type_that_is_not_registered);
            }
        }
    }
}