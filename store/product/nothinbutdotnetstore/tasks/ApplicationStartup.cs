using nothinbutdotnetstore.tasks.startup;
using nothinbutdotnetstore.tasks.startup.dsl;

namespace nothinbutdotnetstore.tasks
{
    public class ApplicationStartup
    {
        public void run()
        {
            Start.by<InitializeTheContainer>()
                 .followed_by<InitializeTheServiceLayer>()
                 .finish_by<InitializingFrontController>();

//            Start.by_loading_pipeline_from("startup_commands.txt");
        }
    }
}