namespace nothinbutdotnetstore.web.core
{
    public interface ResponseHandler
    {
        void Write<T>(ViewModel<T> model);
    }
}