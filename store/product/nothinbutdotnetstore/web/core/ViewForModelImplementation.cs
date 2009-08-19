using System.Web.UI;

namespace nothinbutdotnetstore.web.core
{
    public class ViewForModelImplementation<Model> : Page,ViewForModel<Model>
    {
        public Model model { get; set; }
    }
}