using System;

namespace nothinbutdotnetstore.web.core
{
    public interface ViewModelFactory
    {
        ViewModel<T> create_view_model<T>(string path, Type type);
    }
}