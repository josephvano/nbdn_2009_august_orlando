using System.Web;

namespace nothinbutdotnetstore.web.core
{
    public interface ViewForModel<T> : IHttpHandler
    {
        T model { get; set; }
    }
}