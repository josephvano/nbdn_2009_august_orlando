using System;

namespace nothinbutdotnetstore.web.core
{
    public class MissingRequestCommand : RequestCommand
    {
        public void process(FrontControllerRequest request)
        {
            throw new NotImplementedException();
        }

        public bool can_handle(FrontControllerRequest request)
        {
            return false;
        }
    }
}