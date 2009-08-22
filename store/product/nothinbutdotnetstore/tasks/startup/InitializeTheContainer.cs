using System;
using System.Collections.Generic;
using nothinbutdotnetstore.documenting;
using nothinbutdotnetstore.infrastructure.containers.basic;

namespace nothinbutdotnetstore.tasks.startup
{
    [Command]
    public class InitializeTheContainer : StartupCommand
    {
        public InitializeTheContainer(IDictionary<Type, Resolver> resolvers) {}

        public void run()
        {
            throw new NotImplementedException();
        }
    }
}