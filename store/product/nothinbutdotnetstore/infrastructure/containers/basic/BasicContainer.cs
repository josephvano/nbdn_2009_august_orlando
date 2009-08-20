using System;
using System.Collections.Generic;
using developwithpassion.commons.core.infrastructure.containers;

namespace nothinbutdotnetstore.infrastructure.containers.basic
{
    public class BasicContainer : Container
    {
        IDictionary<Type,Resolver> resolvers;

        public BasicContainer(IDictionary<Type, Resolver> resolvers)
        {
            this.resolvers = resolvers;
        }

        public Dependency instance_of<Dependency>()
        {
            ensure_resolver_exists_for<Dependency>();

                return (Dependency) resolvers[typeof (Dependency)].resolve();
        }

        void ensure_resolver_exists_for<T>()
        {
            if (! resolvers.ContainsKey(typeof(T)))  throw  new UnregisteredTypeException(typeof(T));
        }

        public object instance_of(Type dependency_type)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DependencyType> all_instances_of<DependencyType>()
        {
            throw new NotImplementedException();
        }
    }
}