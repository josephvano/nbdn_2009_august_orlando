using System.Web;

namespace nothinbutdotnetstore.web.core
{
    public interface RequestFactory
    {
        FrontControllerRequest create_from(HttpContext context);
    }
}