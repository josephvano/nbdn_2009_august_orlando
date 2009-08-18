using nothinbutdotnetstore.infrastructure;

namespace nothinbutdotnetstore.web.core
{
    public class BasicRequestCommand : RequestCommand
    {
        Criteria<FrontControllerRequest> request_criteria;
        ApplicationCommand application_command;

        public BasicRequestCommand(
            Criteria<FrontControllerRequest> request_criteria,
            ApplicationCommand application_command)
        {
            this.request_criteria = request_criteria;
            this.application_command = application_command;
        }

        public void process(FrontControllerRequest request)
        {
            application_command.process(request);
        }

        public bool can_handle(FrontControllerRequest request)
        {
            return request_criteria.is_satisfied_by(request);
        }
    }
}