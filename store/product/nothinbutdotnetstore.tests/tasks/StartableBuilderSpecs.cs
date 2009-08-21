 using System.Collections.Generic;
 using developwithpassion.bdd.contexts;
 using developwithpassion.bdd.mbunit.standard.observations;
 using developwithpassion.bdddoc.core;
 using nothinbutdotnetstore.infrastructure;
 using nothinbutdotnetstore.tasks;
 using nothinbutdotnetstore.tasks.startup.dsl;
 using nothinbutdotnetstore.win.core;
 using developwithpassion.bdd.mbunit;

namespace nothinbutdotnetstore.tests.tasks
 {   
     public class StartableBuilderSpecs
     {
         public abstract class concern : observations_for_a_sut_without_a_contract<StartableBuilder>
         
         {
        
         }

         [Concern(typeof(StartableBuilder))]
         public class when_created_with_an_initial_command_type_that_should_serve_as_the_first_command : concern
         {
             context c = () =>
             {
                first_command = an<StartupCommand>();
                 startup_command = the_dependency<StartupCommandFactory>();

             };
        
             it should_place_the_instance_of_the_command_on_the_list_of_commands_to_run = () =>
             {
                list_of_commands .should_contain(first_command);
            
            
             };

             static IList<StartupCommand> list_of_commands;
             static StartupCommand first_command;
             static StartupCommandFactory startup_command;
         }
     }
 }
