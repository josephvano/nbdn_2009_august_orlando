using System.Windows.Forms;

namespace nothinbutdotnetstore.win.core
{
    public interface FileSystemNodeFactory
    {
        TreeNode create_directory_node_with_only_file_name(string path);
        TreeNode create_directory_node_from(string path);
    }
}