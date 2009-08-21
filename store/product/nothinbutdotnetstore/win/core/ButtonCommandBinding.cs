using System.Windows.Forms;
using nothinbutdotnetstore.win.core;

namespace nothinbutdotnetstore.tests.win
{
    public class ButtonCommandBinding
    {
        public ButtonCommandBinding(Button button, Command command)
        {
            button.Click += (o, e) =>
            {
                command.run();
            };
        }
    }
}