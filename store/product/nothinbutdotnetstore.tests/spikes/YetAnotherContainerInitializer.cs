using System;

namespace nothinbutdotnetstore.tests.spikes
{
    public class YetAnotherContainerInitializer : IIinitializer
    {
        public void initialize()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}