namespace nothinbutdotnetstore.tests.spikes
{
    public class StartableBuilder
    {

        public StartableBuilder()
        {
        }

        public StartableBuilder followed_by<T>() where T : IIinitializer, new()
        {
            var t = new T();
            t.initialize();
            return new StartableBuilder();
        }

        public void finished_by<T>() where T : IIinitializer, new() {

            var t = new T();
            t.initialize();
        }
    }
}