using System;
using System.Collections.Generic;
using nothinbutdotnetstore.infrastructure.containers.basic;

namespace nothinbutdotnetstore.tasks.startup
{
    public class InitializingFrontController : StartupCommand
    {
        public InitializingFrontController(IDictionary<Type,Resolver> resolvers) {}

        public void run()
        {

        }
    }
}