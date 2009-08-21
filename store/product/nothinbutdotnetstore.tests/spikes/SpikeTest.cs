using MbUnit.Framework;

namespace nothinbutdotnetstore.tests.spikes
{
    [TestFixture]
    public class SpikeTest
    {
        [Test]
        public void should_be_able_to_do_something_with_my_spike_test() {
            Start.by<InitializingLogging>()
                .followed_by<ToolsInitializer>()
                .followed_by<YetAnotherContainerInitializer>()
                .finished_by<InitializingLogging>();
        }
    }
}