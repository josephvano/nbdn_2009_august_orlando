using System;
using System.Collections.Generic;
using developwithpassion.commons.core.infrastructure.containers;
using nothinbutdotnetstore.documenting;
using nothinbutdotnetstore.infrastructure.containers.basic;

namespace nothinbutdotnetstore.tasks.startup
{
    [Command]
    public class InitializeTheContainer : StartupCommand
    {
        IDictionary<Type, Resolver> resolvers;

        public InitializeTheContainer(IDictionary<Type, Resolver> resolvers)
        {
            this.resolvers = resolvers;
        }

        public void run()
        {
            IOC.initialize_with(new BasicContainer(resolvers));
        }
    }
}