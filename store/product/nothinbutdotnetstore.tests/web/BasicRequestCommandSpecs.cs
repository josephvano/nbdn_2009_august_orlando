using developwithpassion.bdd.contexts;
 using developwithpassion.bdd.mbunit.standard.observations;
 using developwithpassion.bdddoc.core;
 using nothinbutdotnetstore.infrastructure;
 using nothinbutdotnetstore.web.core;
 using developwithpassion.bdd.mbunit;
 using Rhino.Mocks;
 using developwithpassion.bdd;

namespace nothinbutdotnetstore.tests.web
 {   
     public class BasicRequestCommandSpecs
     {
         public abstract class concern : observations_for_a_sut_with_a_contract<RequestCommand,
                                             BasicRequestCommand>
         {
             context c = () =>
             {
                 
                 request = an<FrontControllerRequest>();
             };
             static protected FrontControllerRequest request;
         }


         [Concern(typeof(BasicRequestCommand))]
         public class when_determining_if_it_can_process_a_request : concern
         {
             context c = () =>
             {
                 criteria = the_dependency<Criteria<FrontControllerRequest>>();
                 criteria.Stub(x => x.is_satisfied_by(request)).Return(true);
             };

             because b = () =>
             {
                 result = sut.can_handle(request);
             };

        
             it should_make_the_decision_by_leveraging_its_request_criteria = () =>
             {
                result.should_be_true(); 
             };

             static bool result;
             static Criteria<FrontControllerRequest> criteria;
         }

         [Concern(typeof(BasicRequestCommand))]
         public class when_processing_the_request : concern {

             context c = () =>
             {
                 application_command = the_dependency<ApplicationCommand>();
             };

             because b = () =>
             {
                 sut.process(request);
             };

             it should_dispatch_the_processing_to_the_application_command = () =>
             {
                 application_command.received(x => x.process(request));
             };

             static ApplicationCommand application_command;
         }
     }
 }
