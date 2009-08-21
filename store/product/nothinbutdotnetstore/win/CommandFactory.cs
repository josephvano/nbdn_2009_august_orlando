using nothinbutdotnetstore.win.core;

namespace nothinbutdotnetstore.win
{
    public interface CommandFactory
    {
        Command create_from(Command command_to_add_behaviours_to);
    }
}