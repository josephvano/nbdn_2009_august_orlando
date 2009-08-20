using System.IO;
using System.Windows.Forms;
using nothinbutdotnetstore.win.core;

namespace nothinbutdotnetstore.win.ui
{
    public class FileTreeNode : TreeNode
    {
        public FileTreeNode(SimpleFileInfo file_info) {
            this.file_info = this.file_info;
        }

        public SimpleFileInfo file_info { get; set;} 
    }
}