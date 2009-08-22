using System;
using System.Collections.Generic;
using System.Linq;
using nothinbutdotnetstore.infrastructure.containers.basic;
using nothinbutdotnetstore.tasks;

namespace nothinbutdotnetstore.tests.utility.conventions
{
    public class FollowsStartupCommandConvention : ApplicationConvention
    {
        public bool is_satisfied_by(Type startup_command_type)
        {
            var constructor = startup_command_type.greediest_constructor();
            return constructor.GetParameters().Count() == 1 &&
                   constructor.GetParameters().Select(x => x.ParameterType).First().Equals(typeof (IDictionary<Type, Resolver>));
        }

        public bool applies_to(Type type)
        {
            return typeof (StartupCommand).IsAssignableFrom(type)
                   && type.IsClass && !type.IsAbstract;
        }
    }
}