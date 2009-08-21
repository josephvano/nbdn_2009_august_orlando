 using System;
 using System.Collections.Generic;
 using System.Reflection;
 using System.Windows.Forms;
 using developwithpassion.bdd.contexts;
 using developwithpassion.bdd.mbunit.standard.observations;
 using developwithpassion.bdddoc.core;
 using nothinbutdotnetstore.win.core;

namespace nothinbutdotnetstore.tests.win
 {   
     public class FileSystemNodeFactoryWithCommandCreationSpecs
     {
         public abstract class concern : observations_for_a_sut_with_a_contract<FileSystemNodeFactory,
                                             FileSystemNodeFactoryWithCommandCreation>
         {
        
         }

         [Concern(typeof(FileSystemNodeFactoryWithCommandCreation))]
         public class when_creating_a_directory_node : concern
         {
             context c = () =>
             {
                 path = @"C:\first\users";
                 inner_factory = the_dependency<FileSystemNodeFactory>();
                 command_box = the_dependency<ICollection<Command>>();
                 populate_node_command = the_dependency<Command>();
                 tree = new TreeView();
                 node = new TreeNode();

                 var method_info = typeof(TreeView).GetMethod("OnBeforeExpand"
                                                         , BindingFlags.NonPublic | BindingFlags.Instance);
                 handler = (o, e) => method_info.Invoke(tree, new object[] {new TreeViewCancelEventArgs(node, false, TreeViewAction.Unknown)});

                 provide_a_basic_sut_constructor_argument(inner_factory);
                 provide_a_basic_sut_constructor_argument(command_box);
                 provide_a_basic_sut_constructor_argument(populate_node_command);
             };

             because b = () =>
             {
                 result = sut.create_directory_node_from(path);
             };

             before_all_observations before = () => handler.DynamicInvoke(null);

             it should_wire_the_BeforeExpand_event_to_run_an_ExpandCommand =
                 () => {  };

             it should_store_the_command_in_a_box;

             static FileSystemNodeFactory inner_factory;
             static ICollection<Command> command_box;
             static Command populate_node_command;
             static string path;
             static TreeNode result;
             static TreeNode node;
             static TreeView tree;
             static EventHandler handler;
         }
     }
 }
