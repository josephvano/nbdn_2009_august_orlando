using System;
using System.Collections.Generic;
using nothinbutdotnetstore.infrastructure;
using nothinbutdotnetstore.infrastructure.containers.basic;

namespace nothinbutdotnetstore.tasks.startup.dsl
{
    public class StartableBuilder
    {
        StartupCommandFactory command_factory;
        Command composite_command;
        Dictionary<Type, Resolver> resolvers;
        int command_count;

        public int number_of_commands_to_run
        {
            get { return command_count; }
        }

        public StartableBuilder(Type command_type, StartupCommandFactory command_factory)
        {
            resolvers = new Dictionary<Type, Resolver>();
            this.command_factory = command_factory;

            composite_command = command_factory.create_startup_command(command_type, resolvers);
            
        }

        public StartableBuilder followed_by<T>() where T : StartupCommand
        {
            return followed_by(typeof (T));
        }

        StartableBuilder followed_by(Type command_type)
        {
            var command = command_factory.create_startup_command(command_type, resolvers);
            composite_command = new CompositeCommand(composite_command, command);
            return this;
        }

        public void finished_by<T>() where T : StartupCommand
        {
            followed_by(typeof (T));
            composite_command.run();
        }

        private class CompositeCommand : Command
        {
            readonly Command first;
            readonly Command second;

            public CompositeCommand(Command first, Command second)
            {
                this.first = first;
                this.second = second;
            }

            public void run()
            {
                first.run();
                second.run();
            }
        }
    }


}