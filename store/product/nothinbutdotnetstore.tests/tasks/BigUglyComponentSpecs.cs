 using developwithpassion.bdd.contexts;
 using developwithpassion.bdd.mbunit.standard.observations;
 using developwithpassion.bdddoc.core;
 using nothinbutdotnetstore.tasks.startup.dsl;
 using developwithpassion.bdd;
 using developwithpassion.bdd.mbunit;

namespace nothinbutdotnetstore.tests.tasks
 {   
     public class BigUglyComponentSpecs
     {
         public abstract class concern : observations_for_a_sut_without_a_contract<BigUglyComponent>
         {
        
         }

         [Concern(typeof(BigUglyComponent))]
         public class when_doing_something : concern
         {
             context c = () =>
             {
                 provide_a_basic_sut_constructor_argument(new ReallyMessyDependencyWithShadowing());
             };

             because b = () =>
             {
                sut.some_really_untestable_method(); 
             };

        
             it first_observation = () =>
             {

//                 dependency.received(x => x.do_something());
            
//                 sut.some_list.Count.should_be_equal_to(20);
             };

             static ReallyMessyDependencyThatTalksToDatabase dependency;
         }
     }
 }
