using System.Threading;
using nothinbutdotnetstore.infrastructure;
using nothinbutdotnetstore.win.core;

namespace nothinbutdotnetstore.win
{
    public class CommandFactoryImplementation : CommandFactory
    {
        public Command create_from(Command command_to_add_behaviours_to)
        {
            Thread.CurrentPrincipal = new OurPrincipal();

            return new SecuringCommand(new LoggingCommand(command_to_add_behaviours_to),
                                       new DoesNotHaveOInUserName());
        }


    }
}