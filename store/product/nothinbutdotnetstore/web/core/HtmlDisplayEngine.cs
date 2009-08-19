using System.Web;
using System.Web.Compilation;

namespace nothinbutdotnetstore.web.core
{
    public class HtmlDisplayEngine : DisplayEngine
    {
        static public TransferAction transfer_action =
            (handler, preserve) =>
            HttpContext.Current.Server.Transfer(handler, preserve);

        static public ViewFactory view_factory =
            (path, type) =>
            BuildManager.CreateInstanceFromVirtualPath(path, type);


        public HtmlDisplayEngine(ViewRegistry view_registry)
        {
            this.view_registry = view_registry;
        }

        ViewRegistry view_registry;

        public void display<T>(T item)
        {
            var view_configuration = view_registry.get_view_information_for<T>();
            var handler =
                view_factory(view_configuration.path, view_configuration.type)
                as ViewForModel<T>;
            handler.model = item;
            transfer_action(handler, true);
        }
    }
}