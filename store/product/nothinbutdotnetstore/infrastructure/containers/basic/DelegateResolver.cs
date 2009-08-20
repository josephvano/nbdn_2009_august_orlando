using System;

namespace nothinbutdotnetstore.infrastructure.containers.basic
{
    public class DelegateResolver : Resolver
    {
        readonly Func<object> factory;

        public DelegateResolver(Func<object> factory)
        {
            this.factory = factory;
        }

        public object resolve() {

            return factory();
        }
    }

}