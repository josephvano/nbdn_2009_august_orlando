using System.Windows.Forms;
using developwithpassion.bdd;
using developwithpassion.bdd.contexts;
using developwithpassion.bdd.mbunit;
using developwithpassion.bdd.mbunit.standard.observations;
using developwithpassion.bdddoc.core;
using nothinbutdotnetstore.infrastructure;
using nothinbutdotnetstore.win.core;

namespace nothinbutdotnetstore.tests.win
{
    public class ExpandNodeCommandSpecs
    {
        public abstract class concern
            : observations_for_a_sut_with_a_contract<Command, ExpandNodeCommand> {}

        [Concern(typeof (ExpandNodeCommand))]
        public class when_expanding_a_directory_node : concern
        {
            context c = () =>
            {
                node_to_expand = new TreeNode("users");
                placeholder_node = new TreeNode(@"C:\first\users");
                populate_node_with_directories_command = the_dependency<Command>();

                node_to_expand.Nodes.Add(placeholder_node);
                //TODO: comment this out to ensure that the first assertion fails

                provide_a_basic_sut_constructor_argument(node_to_expand);

                //TODO: figure out how the PopulateNodeWithDirectoriesCommand is going to get its other dependencies
            };

            because b = () =>
            {
                sut.run();
            };

            it should_remove_the_placeholder_child_node =
                () => node_to_expand.Nodes.Contains(placeholder_node).should_be_false();

            it should_invoke_a_populate_node_with_directories_command_using_the_path_from_the_placeholder_node =
                () => populate_node_with_directories_command.received(x => x.run());

            static TreeNode node_to_expand;
            static TreeNode placeholder_node;
            static Command populate_node_with_directories_command;
        }
    }
}