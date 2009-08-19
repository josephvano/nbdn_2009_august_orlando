namespace nothinbutdotnetstore.web.core
{
    public interface FrontControllerRequest
    {
        T map<T>();
        string url
        { get; set; }
    }
}