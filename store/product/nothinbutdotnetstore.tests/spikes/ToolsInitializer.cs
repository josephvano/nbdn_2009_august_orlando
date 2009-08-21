using System;

namespace nothinbutdotnetstore.tests.spikes
{
    public class ToolsInitializer : IIinitializer
    {
        public void initialize()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}