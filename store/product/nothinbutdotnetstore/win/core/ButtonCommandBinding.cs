using System.Windows.Forms;
using nothinbutdotnetstore.infrastructure;

namespace nothinbutdotnetstore.win.core
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