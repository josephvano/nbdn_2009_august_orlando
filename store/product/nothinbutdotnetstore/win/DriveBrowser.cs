using System.Threading;
using System.Windows.Forms;
using nothinbutdotnetstore.win.core;

namespace nothinbutdotnetstore.win
{
    public partial class DriveBrowser : Form
    {
        public DriveBrowser(CommandFactory command_factory)
        {
            InitializeComponent();

            ux_open_file_button.bind_to(
                command_factory.create_from(new ShowContentsOfATextFile(
                                                @"C:\github\nbdn_2009_august_orlando\store\readme.txt",
                                                richTextBox1)));
        }

        public DriveBrowser():this(new CommandFactoryImplementation())
        {
            InitializeComponent();
        }
    }
}