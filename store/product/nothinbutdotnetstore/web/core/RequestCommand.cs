namespace nothinbutdotnetstore.web.core
{
    public interface RequestCommand : ApplicationCommand
    {
        bool can_handle(FrontControllerRequest request);
    }
}