using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace nothinbutdotnetstore.win.core
{
    public class FileSystemNodeFactoryWithCommandCreation : FileSystemNodeFactory
    {
        readonly FileSystemNodeFactory inner_factory;
        readonly ICollection<Command> command_box;
        readonly Command populate_node_command;

        public FileSystemNodeFactoryWithCommandCreation(
            FileSystemNodeFactory inner_factory,
            ICollection<Command> command_box,
            Command populate_node_command
            )
        {
            this.inner_factory = inner_factory;
            this.command_box = command_box;
            this.populate_node_command = populate_node_command;
        }

        public TreeNode create_directory_node_with_only_file_name(string path)
        {
            var new_node = inner_factory.create_directory_node_from(path);

            // construct this ExpandNodeCommand elsewhere or with a factory (?)
            var command = new ExpandNodeCommand(new_node, populate_node_command);
            //command_box.Add(command);
            new_node.TreeView.BeforeExpand += (o, e) =>
            {
                if (e.Node == new_node) command.run();
            };
            
            return new_node;
        }

        public TreeNode create_directory_node_from(string path)
        {
            return inner_factory.create_directory_node_from(path);
        }
    }
}