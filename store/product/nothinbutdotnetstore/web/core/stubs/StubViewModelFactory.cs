using System;
using System.Web.Compilation;
using System.Web.UI;

namespace nothinbutdotnetstore.web.core.stubs
{
    public class StubViewModelFactory : ViewModelFactory
    {
        public ViewModel<T> create_view_model<T>(string path, Type type)
        {
            return BuildManager.CreateInstanceFromVirtualPath(path, type) as ViewModel<T>;
        }
    }
}