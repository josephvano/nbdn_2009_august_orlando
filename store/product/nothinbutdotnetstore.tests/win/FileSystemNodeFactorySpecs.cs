using System.Windows.Forms;
using developwithpassion.bdd.contexts;
using developwithpassion.bdd.mbunit;
using developwithpassion.bdd.mbunit.standard.observations;
using developwithpassion.bdddoc.core;
using nothinbutdotnetstore.win.core;

namespace nothinbutdotnetstore.tests.win
{
    public class FileSystemNodeFactorySpecs
    {
        public abstract class concern : observations_for_a_sut_with_a_contract<FileSystemNodeFactory,
                                            FileSystemNodeFactoryImplementation> {}

        [Concern(typeof (FileSystemNodeFactoryImplementation))]
        public class when_creating_a_directory_node_from_a_path : concern
        {
            context c = () =>
            {
                path = @"C:\first\users";
            };

            because b = () =>
            {
                result = sut.create_diectory_node_with_only_file_name(path);
            };

            it should_create_a_tree_node =
                () => result.should_be_an_instance_of<TreeNode>();

            it should_only_set_the_text_to_the_folder_name_of_the_the_path =
                () => result.Text.should_be_equal_to("users");


            static TreeNode result;
            static string path;
        }

        [Concern(typeof (FileSystemNodeFactoryImplementation))]
        public class when_creating_a_node_for_a_directory : concern
        {
            context c = () =>
            {
                path = @"C:\";
            };

            because b = () => result = sut.create_directory_node_from(path);

            it should_create_a_tree_node_with_a_directory_content_placeholder_tree_node_as_its_sole_child = () =>
            {
                result.should_not_be_null();
            };

            it should_create_a_tree_node_that_is_not_expanded = () => {
                result.Nodes.Count.should_be_equal_to(0);
            };

            static TreeNode result;
            static string path;
        }
    }
}