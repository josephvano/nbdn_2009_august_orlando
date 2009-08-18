namespace nothinbutdotnetstore.web.core
{
    public interface RequestCommand
    {
        void process(FrontControllerRequest request);
        bool can_handle(FrontControllerRequest request);
    }
}