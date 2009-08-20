using System.Windows.Forms;

namespace nothinbutdotnetstore.win.core
{
    public interface FileSystemNodeFactory
    {
        TreeNode create_directory_node_from(string path);
    }
}