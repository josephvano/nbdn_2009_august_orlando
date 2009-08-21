using System;

namespace nothinbutdotnetstore.tests.spikes
{
    public class InitializingLogging : IIinitializer {
        public void initialize()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}