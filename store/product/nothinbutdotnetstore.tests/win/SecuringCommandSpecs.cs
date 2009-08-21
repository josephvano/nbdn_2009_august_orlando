using System.Security.Principal;
using System.Threading;
using developwithpassion.bdd;
using developwithpassion.bdd.contexts;
using developwithpassion.bdd.mbunit.standard.observations;
using developwithpassion.bdddoc.core;
using nothinbutdotnetstore.infrastructure;
using nothinbutdotnetstore.win.core;
using Rhino.Mocks;

namespace nothinbutdotnetstore.tests.win
{
    public class SecuringCommandSpecs
    {
        public abstract class concern :
            observations_for_a_sut_with_a_contract<Command,
                SecuringCommand>
        {
            context c = () =>
            {
                criteria = the_dependency<Criteria<IPrincipal>>();
                our_principal = an<IPrincipal>();
                command_to_run = the_dependency<Command>();


                change(() => Thread.CurrentPrincipal).to(our_principal);
            };

            because b = () =>
            {
                sut.run();
            };


            static protected Criteria<IPrincipal> criteria;
            static protected IPrincipal our_principal;
            static protected Command command_to_run;
        }

        [Concern(typeof (SecuringCommand))]
        public class
            when_run_and_the_current_principal_meets_the_security_constraints :
                concern
        {
            context c = () =>
            {
                criteria.Stub(x => x.is_satisfied_by(our_principal)).Return(true);
            };


            it should_forward_the_call_to_the_command_to_be_run = () =>
            {
                command_to_run.received(x => x.run());
            };

        }

        [Concern(typeof (SecuringCommand))]
        public class
            when_run_and_the_current_principal_does_not_meet_the_security_constraints :
                concern
        {
            context c = () =>
            {
                criteria.Stub(x => x.is_satisfied_by(our_principal)).Return(false);
            };


            it should_not_forward_the_call_to_the_command_to_be_run = () =>
            {
                command_to_run.never_received(x => x.run());
            };

        }
    }
}