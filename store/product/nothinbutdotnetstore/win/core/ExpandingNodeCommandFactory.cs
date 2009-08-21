using System.Windows.Forms;

namespace nothinbutdotnetstore.win.core
{
    public interface ExpandingNodeCommandFactory
    {
        Command create_command(TreeNode node, string path, FileSystemNodeFactory file_system_node_factory);
    }
}