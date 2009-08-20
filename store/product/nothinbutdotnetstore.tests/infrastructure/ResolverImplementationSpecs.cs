 using developwithpassion.bdd.contexts;
 using developwithpassion.bdd.mbunit.standard.observations;
 using developwithpassion.bdddoc.core;
 using nothinbutdotnetstore.infrastructure.containers.basic;

namespace nothinbutdotnetstore.tests.infrastructure
 {   
     public class ResolverImplementationSpecs
     {
         public abstract class concern : observations_for_a_sut_with_a_contract<Resolver,
                                             DelegateResolver>
         {
        
         }

         [Concern(typeof(DelegateResolver))]
         public class when_resolving_an_instance_of_a_given_type : concern
         {
             context c = () =>
             {
            
             };

             because b = () =>
             {
        
             };

        
             it should_return_an_instance_of_that_type = () =>
             {
             };

             it should_
         }
     }
 }
