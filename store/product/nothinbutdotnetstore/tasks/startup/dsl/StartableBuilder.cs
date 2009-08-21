using System;

namespace nothinbutdotnetstore.tasks.startup.dsl
{
    public class StartableBuilder
    {
        readonly Type command_type;

        public StartableBuilder(Type command_type)
        {
            this.command_type= command_type;
        }

        public StartableBuilder followed_by<T>() where T : StartupCommand
        {
            throw new NotImplementedException();
        }

        public void finished_by<T>() where T : StartupCommand
        {
            throw new NotImplementedException();
        }
    }
}