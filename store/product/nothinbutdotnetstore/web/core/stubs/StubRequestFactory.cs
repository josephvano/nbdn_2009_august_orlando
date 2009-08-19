using System;
using System.Web;

namespace nothinbutdotnetstore.web.core.stubs
{
    public class StubRequestFactory : RequestFactory
    {
        public FrontControllerRequest create_from(HttpContext context)
        {
            return new StubRequest();
        }

        class StubRequest : FrontControllerRequest {
            public T map<T>()
            {
                return default(T);
            }
        }
    }
}