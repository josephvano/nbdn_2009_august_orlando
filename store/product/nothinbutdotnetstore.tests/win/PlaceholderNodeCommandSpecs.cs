 using System.Windows.Forms;
 using developwithpassion.bdd;
 using developwithpassion.bdd.contexts;
 using developwithpassion.bdd.mbunit;
 using developwithpassion.bdd.mbunit.standard.observations;
 using developwithpassion.bdddoc.core;
 using nothinbutdotnetstore.win.core;

namespace nothinbutdotnetstore.tests.win
 {   
     public class PlaceholderNodeCommandSpecs
     {
         public abstract class concern : observations_for_a_sut_with_a_contract<Command,
                                             PlaceholderNodeCommand>
         {
        
         }

         [Concern(typeof(PlaceholderNodeCommand))]
         public class when_placeholder_node_command_runs : concern
         {
             context c = () =>
             {
                 path = @"c:\path_to_more_tools";
                 result = an<TreeNode>();
                 current_node = the_dependency<TreeNode>();

                 factory = the_dependency<FileSystemNodeFactory>();
             };

             because b = () =>
             {
                 sut.run();
             };

             it should_add_a_child_node_to_the_current_node = () => {
                 result.Nodes.Count.should_be_greater_than(0);
                 result.Nodes[0].Text.should_be_equal_to(path);
             };

        
             it should_create_a_placeholder_node_with_full_directory_path_of_parent = () =>
             {
                 factory.received(x => x.create_directory_node_from(path));
             };

             static TreeNode result;
             static string path;
             static FileSystemNodeFactory factory;
             static TreeNode current_node;
         }
     }
 }
