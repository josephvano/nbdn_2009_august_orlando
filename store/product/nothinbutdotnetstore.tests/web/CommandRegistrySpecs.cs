using System.Collections.Generic;
using System.Linq;
using developwithpassion.bdd.contexts;
using developwithpassion.bdd.mbunit;
using developwithpassion.bdd.mbunit.standard.observations;
using developwithpassion.bdddoc.core;
using nothinbutdotnetstore.web.core;
using Rhino.Mocks;
using developwithpassion.bdd.core.extensions;

namespace nothinbutdotnetstore.tests.web
{
    public class CommandRegistrySpecs
    {
        public abstract class concern :
            observations_for_a_sut_with_a_contract<CommandRegistry,
                CommandRegistryImplementation>
        {
            context c = () =>
            {
                list_of_commands = new List<RequestCommand>();
                request = an<FrontControllerRequest>();
                provide_a_basic_sut_constructor_argument
                    <IEnumerable<RequestCommand>>(list_of_commands);
            };

            static protected IList<RequestCommand> list_of_commands;
            static protected FrontControllerRequest request;
        }


        [Concern(typeof (CommandRegistryImplementation))]
        public class when_getting_a_command_for_a_request_and_it_has_the_command :
            concern
        {
            context c = () =>
            {
                command_that_can_handle_request = an<RequestCommand>();
                command_that_can_handle_request.Stub(x => x.can_handle(request))
                    .Return(true);

                list_of_commands.Add(command_that_can_handle_request);
                list_of_commands.Add(command_that_can_handle_request);
            };

            because b = () =>
            {
                result = sut.get_command_that_can_handle(request);
            };


            it should_return_the_command_to_the_caller = () =>
            {
                result.should_be_equal_to(command_that_can_handle_request);
            };

            static RequestCommand result;
            static RequestCommand command_that_can_handle_request;
        }

        public class
            when_getting_a_command_for_a_request_and_it_does_not_have_the_command :
                concern
        {
            context c = () =>
            {
                Enumerable.Range(1,10).each(x => list_of_commands.Add(an<RequestCommand>()));
            };
            because b = () =>
            {
                result = sut.get_command_that_can_handle(request);
            };

            it should_return_a_missing_command_to_the_caller = () =>
            {
                result.should_be_an_instance_of<MissingRequestCommand>();
            };

            static RequestCommand result;
        }
    }
}