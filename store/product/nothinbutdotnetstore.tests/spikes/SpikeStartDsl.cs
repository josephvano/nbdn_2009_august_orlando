namespace nothinbutdotnetstore.tests.spikes
{
    public class SpikeStartDsl {

        public void test() {
            Start.by<InitializingLogging>()
                .followed_by<ToolsInitializer>()
                .followed_by<YetAnotherContainerInitializer>()
                .finished_by<InitializingLogging>();
        }
    }
}