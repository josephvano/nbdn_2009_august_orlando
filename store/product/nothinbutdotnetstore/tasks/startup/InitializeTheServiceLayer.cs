using System;
using System.Collections.Generic;
using nothinbutdotnetstore.infrastructure.containers.basic;
using nothinbutdotnetstore.tasks.stubs;

namespace nothinbutdotnetstore.tasks.startup
{
    public class InitializeTheServiceLayer : StartupCommand
    {
        IDictionary<Type, Resolver> resolvers;

        public InitializeTheServiceLayer(IDictionary<Type,Resolver> resolvers)
        {
            this.resolvers = resolvers;
        }

        public void run()
        {
            resolvers.Add(typeof(CatalogTasks),new DelegateResolver(() =>new StubCatalogTasks()));
        }
    }
}