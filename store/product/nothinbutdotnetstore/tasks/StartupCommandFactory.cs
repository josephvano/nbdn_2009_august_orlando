using System;
using System.Collections.Generic;
using nothinbutdotnetstore.infrastructure.containers.basic;

namespace nothinbutdotnetstore.tasks
{
    public interface StartupCommandFactory
    {
        StartupCommand create_startup_command(Type command_type,IDictionary<Type,Resolver> resolvers);
    }
}