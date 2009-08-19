using System;
using System.Collections.Generic;
using System.Linq;
using nothinbutdotnetstore.web.application;
using nothinbutdotnetstore.web.core.stubs;

namespace nothinbutdotnetstore.web.core
{
    public class CommandRegistryImplementation : CommandRegistry
    {
        IEnumerable<RequestCommand> commands;

        public CommandRegistryImplementation() :this(create_dummy_commands()){}

        static IEnumerable<RequestCommand> create_dummy_commands()
        {
            yield return new BasicRequestCommand(new StubAnyCriteria(),
                                                 new ViewMainDepartments());

        }

        public CommandRegistryImplementation(IEnumerable<RequestCommand> commands)
        {
            this.commands = commands;
        }

        public RequestCommand get_command_that_can_handle(
            FrontControllerRequest request) {

            return commands.FirstOrDefault(
                       command => command.can_handle(request))
                   ?? new MissingRequestCommand();
        }
    }
}