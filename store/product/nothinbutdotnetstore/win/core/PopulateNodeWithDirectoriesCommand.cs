using System.Windows.Forms;
using nothinbutdotnetstore.infrastructure;

namespace nothinbutdotnetstore.win.core
{
    public class PopulateNodeWithDirectoriesCommand : Command
    {
        TreeNode node;
        FileSystemNodeFactory node_factory;
        FileSystem file_system;
        string path;

        public PopulateNodeWithDirectoriesCommand(TreeNode node,
                FileSystemNodeFactory node_factory,
                                                  FileSystem file_system,
                                                  string path)
        {
            this.node = node;
            this.node_factory = node_factory;
            this.file_system = file_system;
            this.path = path;
        }

        public void run() {
        
            file_system.get_directories(path).each(sub_directory => node.Nodes.Add(
                node_factory.create_diectory_node_with_only_file_name(sub_directory)));
        }
    }
}