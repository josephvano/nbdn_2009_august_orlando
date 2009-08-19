using System.Web.UI;

namespace nothinbutdotnetstore.web.core
{
    public class ViewModel<T> : Page
    {
        public ViewModel() {}

        public T data
        {
            get; set;
        }
    }
}