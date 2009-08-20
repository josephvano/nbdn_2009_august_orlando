using System.Windows.Forms;

namespace nothinbutdotnetstore.win.core
{
    public interface FileSystemNodeFactory
    {
        TreeNode create_from(string path);
    }
}