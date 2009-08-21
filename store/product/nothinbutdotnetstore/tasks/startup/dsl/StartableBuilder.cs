using System;
using System.Collections.Generic;

namespace nothinbutdotnetstore.tasks.startup.dsl
{
    public class StartableBuilder
    {
        Type command_type;
        StartupCommandFactory command_factory;
        IList<StartupCommand> commands;

        public StartableBuilder(Type command_type,StartupCommandFactory command_factory, IList<StartupCommand> commands)
        {
            this.command_type= command_type;
            this.commands = commands;
            this.command_factory = command_factory;

            commands.Add(command_factory.create_startup_command(command_type));
        }

        public StartableBuilder followed_by<T>() where T : StartupCommand
        {
            throw new NotImplementedException();
        }

        public void finished_by<T>() where T : StartupCommand
        {
            throw new NotImplementedException();
        }
    }
}