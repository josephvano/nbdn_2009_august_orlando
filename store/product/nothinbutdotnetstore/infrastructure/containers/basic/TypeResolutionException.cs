using System;

namespace nothinbutdotnetstore.infrastructure.containers.basic
{
    public class TypeResolutionException : Exception
    {
        readonly Resolver resolver;

        public TypeResolutionException(Resolver resolver) {
            this.resolver = resolver;
        }

        public Resolver resolver_throwing_exception { get { return resolver; } }
    }
}