using System.IO;
using System.Windows.Forms;
using nothinbutdotnetstore.win.core;

namespace nothinbutdotnetstore.win.ui
{
    public class DirectoryTreeNodeImpl : TreeNode, DirectoryTreeNode
    {
        public DirectoryTreeNodeImpl(SimpleDirectoryInfo directory_info) {
            this.directory_info = directory_info;
        }

        public SimpleDirectoryInfo directory_info { get; set;} 
    }
}