namespace nothinbutdotnetstore.tests.spikes
{
    public class Start
    {
        static public StartableBuilder by<T>() where T : IIinitializer, new()
        {
            var t = new T();
            t.initialize();
            return new StartableBuilder();
        }
    }
}