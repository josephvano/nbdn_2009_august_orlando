using System;

namespace nothinbutdotnetstore.tasks.startup
{
    public class InitializingLogging : StartupCommand {
        public void run()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}