namespace nothinbutdotnetstore.web.core
{
    public class FrontControllerImplementation : FrontController
    {
        CommandRegistry command_registry;

        public FrontControllerImplementation()
            : this(new CommandRegistryImplementation()) {}

        public FrontControllerImplementation(CommandRegistry command_registry)
        {
            this.command_registry = command_registry;
        }

        public void handle(FrontControllerRequest request)
        {
            command_registry.get_command_that_can_handle(request).process(
                request);
        }
    }
}