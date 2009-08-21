using System.IO;
using System.Windows.Forms;

namespace nothinbutdotnetstore.win.core
{
    public class ShowContentsOfATextFile : Command
    {
        string file_name;
        RichTextBox rich_text_box;

        public ShowContentsOfATextFile(string file_name, RichTextBox rich_text_box)
        {
            this.file_name = file_name;
            this.rich_text_box = rich_text_box;
        }

        public void run()
        {
            rich_text_box.Text = File.ReadAllText(file_name);
        }
    }
}