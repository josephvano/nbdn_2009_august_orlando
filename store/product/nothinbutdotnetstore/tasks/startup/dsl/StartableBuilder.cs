using System;

namespace nothinbutdotnetstore.tasks.startup.dsl
{
    public class StartableBuilder
    {
        public StartableBuilder(StartupCommand command)
        {
            throw new NotImplementedException();
        }

        public StartableBuilder followed_by<T>() where T : StartupCommand, new()
        {
            var t = new T();
            return new StartableBuilder();
        }

        public void finished_by<T>() where T : StartupCommand, new() {

            var t = new T();
            t.run();
        }
    }
}