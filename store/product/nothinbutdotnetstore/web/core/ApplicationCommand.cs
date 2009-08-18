namespace nothinbutdotnetstore.web.core
{
    public interface ApplicationCommand
    {
        void process(FrontControllerRequest request);
    }
}