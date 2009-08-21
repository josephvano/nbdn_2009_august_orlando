using System.Windows.Forms;

namespace nothinbutdotnetstore.win.core
{
    public class ExpandNodeCommand : Command
    {
        readonly TreeNode current_node;
        Command populate_command;

        public ExpandNodeCommand(TreeNode current_node, Command populate_command)
        {
            this.current_node = current_node;
            this.populate_command = populate_command;
        }

        public void run()
        {
            current_node.Nodes.Clear();

            populate_command.run();
        }
    }
}