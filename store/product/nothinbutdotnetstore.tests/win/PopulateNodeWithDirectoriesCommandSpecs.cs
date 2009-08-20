using System.Collections.Generic;
using System.IO;
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

                file_system.Stub(x => x.get_directories(path)).Return(directories);
                node_factory.Stub(x => x.create_from(Arg<string>.Is.NotNull)).
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
    }
}