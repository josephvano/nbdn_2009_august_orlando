using System;
using System.Collections.Generic;
using System.Linq;

namespace nothinbutdotnetstore.web.core
{
    public class CommandRegistryImplementation : CommandRegistry
    {
        IEnumerable<RequestCommand> commands;

        public CommandRegistryImplementation(IEnumerable<RequestCommand> commands)
        {
            this.commands = commands;
        }

        public RequestCommand get_command_that_can_handle(
            FrontControllerRequest request) {

            return commands.First(command => command.can_handle(request));
        }
    }
}