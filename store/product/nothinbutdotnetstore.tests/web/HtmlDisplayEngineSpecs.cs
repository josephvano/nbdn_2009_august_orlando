 using System.Collections.Generic;
 using developwithpassion.bdd;
 using developwithpassion.bdd.contexts;
 using developwithpassion.bdd.mbunit.standard.observations;
 using developwithpassion.bdddoc.core;
 using nothinbutdotnetstore.dto;
 using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.tests.web
 {   
     public class HtmlDisplayEngineSpecs
     {
         public abstract class concern : observations_for_a_sut_with_a_contract<DisplayEngine,
                                             HtmlDisplayEngine>
         {
        
         }

         [Concern(typeof(HtmlDisplayEngine))]
         public class when_displaying_departments : concern
         {
             context c = () =>
             {
                 configuration_handler = the_dependency<ConfigurationHandler>();
                 view_model_factory = the_dependency<ViewModelFactory>();
                 response_handler = the_dependency<ResponseHandler>();


             };

             because b = () =>
             {
                 sut.display(catalog_items);
             };

        
             it should_display_departments = () =>
             {
                 response_handler.received(x => x.Write(model));
             };

             static IEnumerable<DepartmentItem> catalog_items;
             static ConfigurationHandler configuration_handler;
             static ViewModelFactory view_model_factory;
             static ResponseHandler response_handler;
             static ViewModel<IEnumerable<DepartmentItem>> model;
         }
     }
 }
