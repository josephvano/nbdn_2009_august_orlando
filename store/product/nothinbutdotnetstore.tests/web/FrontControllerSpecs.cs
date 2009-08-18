using developwithpassion.bdd;
using developwithpassion.bdd.contexts;
using developwithpassion.bdd.mbunit.standard.observations;
using developwithpassion.bdddoc.core;
using nothinbutdotnetstore.web.core;
using Rhino.Mocks;

namespace nothinbutdotnetstore.tests.web
{
    public class FrontControllerSpecs
    {
        public abstract class concern :
            observations_for_a_sut_with_a_contract<FrontController,
                FrontControllerImplementation> {}

        [Concern(typeof (FrontControllerImplementation))]
        public class when_handling_an_incoming_request : concern
        {
            context c = () =>
            {
                request = an<FrontControllerRequest>();
                command_registry =
                    the_dependency<CommandRegistry>();
                command_that_can_process = an<RequestCommand>();

                command_registry.Stub(
                    x => x.get_command_that_can_handle(request)).Return(
                    command_that_can_process);

            };

            because b = () =>
            {
                sut.handle(request);
            };


            it
                should_tell_the_command_that_can_handle_the_request_to_do_its_work
                    = () =>
                    {
                        command_that_can_process.received(
                            x => x.process(request));
                    };

            static CommandRegistry command_registry;
            static FrontControllerRequest request;
            static RequestCommand command_that_can_process;
        }
    }
}