using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using developwithpassion.bdd.contexts;
using developwithpassion.bdd.mbunit;
using developwithpassion.bdd.mbunit.standard.observations;
using developwithpassion.bdddoc.core;
using nothinbutdotnetstore.tests.utility;
using nothinbutdotnetstore.win.core;
using Rhino.Mocks;

namespace nothinbutdotnetstore.tests.win
{
    public class PopulateNodeWithDirectoriesCommandSpecs
    {
        public abstract class concern :
            observations_for_a_sut_with_a_contract<Command,
                PopulateNodeWithDirectoriesCommand> {}

        [Concern(typeof (PopulateNodeWithDirectoriesCommand))]
        public class when_populating_a_node_with_directory_nodes : concern
        {
            context c = () =>
            {
                child_node = new TreeNode();
                root_node = new TreeNode();
                path = "blah";


                file_system = the_dependency<FileSystem>();
                node_factory = the_dependency<FileSystemNodeFactory>();

                directories = ObjectMother.create_enumerable_from("users",
                                                                  "local",
                                                                  "blah");

                file_system.Stub(x => x.get_directories(path)).Return(
                    directories);
                node_factory.Stub(
                    x =>
                    x.create_directory_node_from(
                        Arg<string>.Is.NotNull)).
                    Return(child_node);

                provide_a_basic_sut_constructor_argument(path);
                provide_a_basic_sut_constructor_argument(root_node);
            };

            because b = () =>
            {
                sut.run();
            };

            it
                should_populate_the_node_with_a_node_for_each_of_the_directories_in_a_specific_directory
                    = () =>
                    {
                        root_node.Nodes.Count.should_be_equal_to(3);
                    };


            static FileSystem file_system;
            static IEnumerable<string> directories;
            static FileSystemNodeFactory node_factory;
            static TreeNode child_node;
            static TreeNode root_node;
            static string path;
        }

        [Concern(typeof (PopulateNodeWithDirectoriesCommand))]
        public class when_displaying_the_folders_in_the_c_drive : concern
        {
            context c = () =>
            {
                host = new Form();
                tree = new TreeView();

                root_node = new TreeNode(@"C:\");

                tree.Nodes.Add(root_node);
                host.Controls.Add(tree);
                tree.Dock = DockStyle.Fill;
                tree.Show();

                provide_a_basic_sut_constructor_argument(@"C:\");
                provide_a_basic_sut_constructor_argument<FileSystem>(
                    new FileSystemImplementation());
                provide_a_basic_sut_constructor_argument(root_node);
                provide_a_basic_sut_constructor_argument<FileSystemNodeFactory>(
                    new FileSystemNodeFactoryImplementation());
            };


            because b = () =>
            {
                sut.run();
            };


            it should_populate_the_tree_view_with_directories_in_the_c_drive
                = () =>
                {
                    root_node.Nodes.Count.should_be_equal_to(
                        Directory.GetDirectories(@"C:\").Count());

                    host.ShowDialog();
                };

            static Form host;
            static TreeView tree;
            static TreeNode root_node;
        }
    }
}