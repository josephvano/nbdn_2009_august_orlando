namespace nothinbutdotnetstore.web.core
{
    public interface ViewRegistry
    {
        View get_view_information_for<Model>();
    }
}