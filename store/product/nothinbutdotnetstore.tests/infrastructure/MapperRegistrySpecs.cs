 using developwithpassion.bdd.contexts;
 using developwithpassion.bdd.mbunit.standard.observations;
 using developwithpassion.bdddoc.core;
 using nothinbutdotnetstore.infrastructure;
 using developwithpassion.bdd.mbunit;

namespace nothinbutdotnetstore.tests.infrastructure
 {   
     public class MapperRegistrySpecs
     {
         public abstract class concern : observations_for_a_sut_with_a_contract<MapperRegistry,
                                             MapperRegistryImplmentation>
         {
        
         }

         [Concern(typeof(MapperRegistryImplmentation))]
         public class when_getting_a_mapper : concern
         {
             context c = () =>
             {
                mapper = container_dependency<Mapper<int,string>>(); 
             };

             because b = () =>
             {
                 result = sut.get_mapper_to_map<int, string>();
             };

        
             it should_return_the_mapper_that_was_registered_in_the_container = () =>
             {
                result .should_be_equal_to(mapper);
            
            
             };

             static Mapper<int,string> result;
             static Mapper<int, string> mapper;
         }
     }
 }
