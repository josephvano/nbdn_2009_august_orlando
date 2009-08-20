 using developwithpassion.bdd.contexts;
 using developwithpassion.bdd.mbunit.standard.observations;
 using developwithpassion.bdddoc.core;
 using nothinbutdotnetstore.win.core;

namespace nothinbutdotnetstore.tests.win
 {   
     public class AddNodeCommandSpecs
     {
         public abstract class concern : observations_for_a_sut_with_a_contract<Command,
                                             AddNodeCommand>
         {
        
         }

         [Concern(typeof(AddNodeCommand))]
         public class when_adding_a_node_to_a_node : concern
         {
             context c = () =>
             {
            
             };

             because b = () =>
             {
        
             };

        
             it should_add_the_child_node_to_the_parents_node_collection = () =>
             {
                 
            
            
             };
         }
     }
 }
