 using developwithpassion.bdd;
 using developwithpassion.bdd.contexts;
 using developwithpassion.bdd.mbunit.standard.observations;
 using developwithpassion.bdddoc.core;
 using nothinbutdotnetstore.win.core;
 using nothinbutdotnetstore.win.ui;

namespace nothinbutdotnetstore.tests.win
 {   
     public class PopulateNodeWithDirectoriesCommandSpecs
     {
         public abstract class concern : observations_for_a_sut_with_a_contract<Command,
                                             PopulateNodeWithDirectoriesCommand>
         {
         }

         [Concern(typeof(PopulateNodeWithDirectoriesCommand))]
         public class when_populating_a_node_with_directory_nodes : concern
         {
             context c = () =>
             {
                 current_node = the_dependency<DirectoryTreeNode>();
                 directory_info = an<SimpleDirectoryInfo>();

                 current_node.directory_info = directory_info;
             };

             because b = () =>
             {
                 sut.run();
             };


             it should_get_the_subdirectories =
                 () => directory_info.received(x => x.get_directories());

             it should_add_a_node_for_each_subdirectory;
             
             static SimpleDirectoryInfo directory_info;
             static DirectoryTreeNode current_node;
         }
     }
 }
