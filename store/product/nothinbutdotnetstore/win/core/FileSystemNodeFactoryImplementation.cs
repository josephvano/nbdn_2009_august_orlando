using System.IO;
using System.Windows.Forms;

namespace nothinbutdotnetstore.win.core
{
    public class FileSystemNodeFactoryImplementation : FileSystemNodeFactory
    {
        public TreeNode create_diectory_node_with_only_file_name(string path)
        {
            return create_directory_node_from(Path.GetFileName(path));
        }

        public TreeNode create_directory_node_from(string path)
        {
            return new TreeNode(path);
        }
    }
}