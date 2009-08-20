using System;
using System.Windows.Forms;
using nothinbutdotnetstore.win.core;

namespace nothinbutdotnetstore.win.ui
{
    public interface DirectoryTreeNode
    {
        SimpleDirectoryInfo directory_info { get; set; }
        TreeNodeCollection Nodes { get; }
    }

    public interface SimpleTreeNodeCollection
    {
        void Add(TreeNode tree_node);
    }

    public class SimpleTreeNodeCollectionImpl : SimpleTreeNodeCollection
    {
        readonly TreeNodeCollection node_collection;

        public SimpleTreeNodeCollectionImpl(TreeNodeCollection node_collection) {
            this.node_collection = node_collection;
        }

        public void Add(TreeNode tree_node)
        {
            
        }
    }
}