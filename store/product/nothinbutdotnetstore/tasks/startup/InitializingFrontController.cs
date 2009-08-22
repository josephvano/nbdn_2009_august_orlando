using System;
using System.Collections.Generic;
using nothinbutdotnetstore.infrastructure.containers.basic;

namespace nothinbutdotnetstore.tasks.startup
{
    public class InitializingFrontController : StartupCommand
    {
        readonly IDictionary<Type, Resolver> resolvers;

        public InitializingFrontController(IDictionary<Type,Resolver> resolvers)
        {
            this.resolvers = resolvers;
        }

        public void run()
        {

        }
    }
}