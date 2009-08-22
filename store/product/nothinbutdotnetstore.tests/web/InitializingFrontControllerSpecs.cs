 using developwithpassion.bdd.contexts;
 using developwithpassion.bdd.mbunit.standard.observations;
 using developwithpassion.bdddoc.core;
 using nothinbutdotnetstore.tasks;
 using nothinbutdotnetstore.tasks.startup;

namespace nothinbutdotnetstore.tests.web
 {   
     public class InitializingFrontControllerSpecs
     {
         public abstract class concern : observations_for_a_sut_with_a_contract<StartupCommand,
                                             InitializingFrontController>
         {
        
         }

         [Concern(typeof(InitializingFrontController))]
         public class when_observation_name : concern
         {
             context c = () =>
             {
            
             };

             because b = () =>
             {
        
             };

        
             it first_observation = () =>
             {
                 
            
            
             };
         }
     }
 }
