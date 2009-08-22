using System;
using System.Collections.Generic;
using nothinbutdotnetstore.infrastructure.containers.basic;

namespace nothinbutdotnetstore.tasks.startup.dsl
{
    public class StartableBuilder
    {
        Type command_type;
        StartupCommandFactory command_factory;
        IList<StartupCommand> commands;
        Dictionary<Type, Resolver> resolvers;

        public StartableBuilder(Type command_type, StartupCommandFactory command_factory, IList<StartupCommand> commands)
        {
            resolvers = new Dictionary<Type, Resolver>();
            this.command_type = command_type;
            this.commands = commands;
            this.command_factory = command_factory;

            followed_by(command_type);
        }

        public StartableBuilder followed_by<T>() where T : StartupCommand
        {
            return followed_by(typeof (T));
        }

        StartableBuilder followed_by(Type command_type)
        {
            commands.Add(command_factory.create_startup_command(command_type, resolvers));
            return this;
        }

        public void finished_by<T>() where T : StartupCommand
        {
            followed_by(typeof (T));

            foreach (var command in commands)
            {
                command.run();
            }
        }
    }
}