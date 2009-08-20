using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using nothinbutdotnetstore.win.ui;

namespace nothinbutdotnetstore.win.core
{
    public class PopulateNodeWithDirectoriesCommand : Command
    {
        readonly DirectoryTreeNode current_node;

        public PopulateNodeWithDirectoriesCommand(DirectoryTreeNode current_node) {
            this.current_node = current_node;
        }

        public void run()
        {
            SimpleDirectoryInfo directory_info = current_node.directory_info;
            var subdirectories = directory_info.get_directories();
            var nodes = current_node.Nodes;
            foreach(var directory in subdirectories)
            {
                //nodes.Add()
                // use AddNodeCommand and NodeFactory to avoid constructing nodes here?
            }
        }
    }

    public class AddNodeCommand : Command
    {
        readonly TreeNode parent_node;
        readonly TreeNode child_node;

        public AddNodeCommand(TreeNode parent, TreeNode child)
        {
            this.parent_node = parent;
            this.child_node = child;
        }

        public void run()
        {
            parent_node.Nodes.Add(child_node);
        }
    }
}