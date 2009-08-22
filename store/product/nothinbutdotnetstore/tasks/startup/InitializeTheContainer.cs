using System;
using System.Collections.Generic;
using nothinbutdotnetstore.infrastructure.containers.basic;

namespace nothinbutdotnetstore.tasks.startup
{
    public class InitializeTheContainer : StartupCommand
    {
        public InitializeTheContainer(IDictionary<Type, Resolver> resolvers) {}

        public void run()
        {
            throw new NotImplementedException();
        }
    }
}