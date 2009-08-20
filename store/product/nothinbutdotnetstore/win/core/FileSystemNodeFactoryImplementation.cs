using System.IO;
using System.Windows.Forms;

namespace nothinbutdotnetstore.win.core
{
    public class FileSystemNodeFactoryImplementation : FileSystemNodeFactory
    {
        public TreeNode create_directory_node_from(string path)
        {
            return new TreeNode(Path.GetFileName(path));
        }
    }
}