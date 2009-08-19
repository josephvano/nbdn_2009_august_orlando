using System.Web;
using nothinbutdotnetstore.web.core.stubs;

namespace nothinbutdotnetstore.web.core
{
    public class HtmlDisplayEngine : DisplayEngine
    {
        ConfigurationHandler configuration_handler;
        ViewModelFactory view_model_factory;
        public HtmlDisplayEngine() : this(new StubConfigurationHandler(), new StubViewModelFactory() ) {}

        public HtmlDisplayEngine(ConfigurationHandler configuration_handler, ViewModelFactory view_model_factory)
        {
            this.configuration_handler = configuration_handler;
            this.view_model_factory = view_model_factory;
        }

        public void display<T>(T item)
        {
            var path = configuration_handler.get_view_path();
            var model = view_model_factory.create_view_model<T>(path, typeof(ViewModel<T>));
            model.data = item;
            HttpContext.Current.Response.Write(model);
        }
    }
}