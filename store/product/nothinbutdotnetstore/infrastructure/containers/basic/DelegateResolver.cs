using System;

namespace nothinbutdotnetstore.infrastructure.containers.basic
{
    public class DelegateResolver : Resolver
    {
        public DelegateResolver(Func) {
        }

        public object resolve() { throw new NotImplementedException(); }
    }

}