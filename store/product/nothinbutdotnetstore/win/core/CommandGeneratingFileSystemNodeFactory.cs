using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace nothinbutdotnetstore.win.core
{
    public class ExpandingFileSystemNodeFactory : FileSystemNodeFactory
    {
        ExpandingNodeCommandFactory expanding_node_command_factory;
        FileSystemNodeFactory inner_factory;
        TreeView tree;

        public ExpandingFileSystemNodeFactory(
            FileSystemNodeFactory inner_factory,
            ExpandingNodeCommandFactory expanding_node_command_factory, TreeView tree)
        {
            this.inner_factory = inner_factory;
            this.tree = tree;
            this.expanding_node_command_factory = expanding_node_command_factory;
        }

        public TreeNode create_directory_node_from(string path)
        {
            var node = inner_factory.create_directory_node_from(path);
            var command = expanding_node_command_factory.create_command(node, path, this);

            tree.BeforeExpand += (o, e) => {

                if (e.Node == node) command.run(); 
            };
            return node;
        }
    }
}