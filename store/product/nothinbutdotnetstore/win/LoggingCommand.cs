using System;
using nothinbutdotnetstore.win.core;

namespace nothinbutdotnetstore.win
{
    public class LoggingCommand : Command
    {
        Command to_persist;

        public LoggingCommand(Command to_persist)
        {
            this.to_persist = to_persist;
        }

        public void run()
        {
            log();
            to_persist.run();
        }

        void log()
        {
            Console.Out.WriteLine("About to run the command {0}",
                                  to_persist.GetType().Name);
        }
    }
}