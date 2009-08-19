 using System.Web;
 using developwithpassion.bdd.contexts;
 using developwithpassion.bdd.mbunit.standard.observations;
 using developwithpassion.bdddoc.core;
 using nothinbutdotnetstore.web.core;
 using developwithpassion.bdd.mbunit;
 using Rhino.Mocks;

namespace nothinbutdotnetstore.tests.web
 {   
     public class HtmlDisplayEngineSpecs
     {
         public abstract class concern : observations_for_a_sut_with_a_contract<DisplayEngine,
                                             HtmlDisplayEngine>
         {
        
         }

         [Concern(typeof(HtmlDisplayEngine))]
         public class when_displaying_a_view_model : concern
         {
             context c = () =>
             {
                 number = 3;
                 view_registry = the_dependency<ViewRegistry>();
                 view_factory = the_dependency<ViewFactory>();
                 view = an<ViewForModel<int>>();
                 view_configuration = new View { path = "blah", type = typeof(int) };
                     

                 view_registry.Stub(x => x.get_view_information_for<int>()).
                     Return(view_configuration);


                 view_factory = (path, type) =>
                 {
                     view_properties_that_were_used_to_create_the_view = new View { path = path, type = type };
                     return view;
                 };
                 transfer_action = (handler, preserve) => {
                     handler_invoked = handler; 
                 };

                 change(() =>HtmlDisplayEngine.transfer_action).to(transfer_action);
                 change(() =>HtmlDisplayEngine.view_factory).to(view_factory);

             };

             because b = () =>
             {
                    sut.display(number); 
             };


             it should_use_the_view_factory_to_create_the_view = () =>
             {
                view_properties_that_were_used_to_create_the_view.path.should_be_equal_to(view_configuration.path); 
                view_properties_that_were_used_to_create_the_view.type.should_be_equal_to(view_configuration.type); 

             };
             it should_have_populated_the_view_with_the_view_model = () =>
             {
                view.model.should_be_equal_to(number);
             };
             it should_transfer_control_for_processing_to_the_view_that_was_created = () =>
             {
                 handler_invoked.should_be_equal_to(view);
             };

             static TransferAction transfer_action;
             static IHttpHandler handler_invoked;
             static ViewForModel<int> view;
             static int number;
             static ViewFactory view_factory;
             static View view_configuration;
             static ViewRegistry view_registry;
             static View view_properties_that_were_used_to_create_the_view;
         }
     }
 }
