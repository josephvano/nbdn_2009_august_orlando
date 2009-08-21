 
using developwithpassion.bdd.contexts;
using developwithpassion.bdd.mbunit.standard.observations;
using developwithpassion.bdddoc.core;
using developwithpassion.commons.core.infrastructure.containers;
using nothinbutdotnetstore.tasks;
using nothinbutdotnetstore.web.core;
using developwithpassion.bdd.mbunit;

namespace nothinbutdotnetstore.tests.tasks
{
    public class ApplicationStartupSpecs
    {
        public abstract class concern : observations_for_a_sut_without_a_contract<ApplicationStartup> {}

        [Concern(typeof (ApplicationStartup))]
        public class when_startup_has_completed : concern
        {
            because b = () => {

                sut.run();
            };

            it should_be_able_to_access_key_app_services = () =>
            {
                IOC.get().instance_of<FrontController>().should_not_be_null();
            };
        }
    }
}
