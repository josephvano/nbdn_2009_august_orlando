using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using developwithpassion.bdd;
using developwithpassion.bdd.contexts;
using developwithpassion.bdd.mbunit.standard.observations;
using developwithpassion.bdddoc.core;
using nothinbutdotnetstore.win.core;
using Rhino.Mocks;

namespace nothinbutdotnetstore.tests.win
{
    public class ExpandingFileSystemNodeFactorySpecs
    {
        public abstract class concern :
            observations_for_a_sut_with_a_contract<FileSystemNodeFactory,
                ExpandingFileSystemNodeFactory> {}

        [Concern(typeof (ExpandingFileSystemNodeFactory))]
        public class when_creating_a_directory_node : concern
        {
            context c = () =>
            {
                path = @"C:\first\users";
                inner_factory = the_dependency<FileSystemNodeFactory>();
                expand_command_factory =
                    the_dependency<ExpandingNodeCommandFactory>();
                populate_node_command = an<Command>();
                node = new TreeNode();
                tree = new TreeView();

                tree.Nodes.Add(node);


                var method_info = typeof (TreeView).GetMethod("OnBeforeExpand"
                                                              ,
                                                              BindingFlags.
                                                                  NonPublic |
                                                              BindingFlags.
                                                                  Instance);

                handler = (o, e) => method_info.Invoke(o, new object[] {e});

                provide_a_basic_sut_constructor_argument(tree);

                inner_factory.Stub(x => x.create_directory_node_from(path))
                    .Return(node);

                expand_command_factory.Stub(
                    x => x.create_command(
                             Arg<TreeNode>.Is.Equal(node),
                             Arg<string>.Is.Equal(path),
                             Arg<FileSystemNodeFactory>.Is.NotNull)).Return(
                    populate_node_command);

            };

            because b = () =>
            {
                result = sut.create_directory_node_from(path);
            };

            it should_wire_the_BeforeExpand_event_to_run_an_ExpandCommand =
                () =>
                {
                    node.Nodes.Add(result);
                    handler(tree,
                            new TreeViewCancelEventArgs(result, false,
                                                        TreeViewAction.
                                                            Expand));

                    populate_node_command.received(x => x.run());
                };


            static FileSystemNodeFactory inner_factory;
            static ICollection<Command> command_box;
            static Command populate_node_command;
            static string path;
            static TreeNode result;
            static TreeNode node;
            static TreeView tree;
            static TreeViewCancelEventHandler handler;
            static ExpandingNodeCommandFactory expand_command_factory;
        }
    }
}