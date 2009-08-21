using System.Windows.Forms;
using nothinbutdotnetstore.infrastructure;

namespace nothinbutdotnetstore.win.core {
    static public class UIExtensions {
        static public void bind_to(this Button button, Command command) {
            new ButtonCommandBinding(button, command);
        }
    }
}