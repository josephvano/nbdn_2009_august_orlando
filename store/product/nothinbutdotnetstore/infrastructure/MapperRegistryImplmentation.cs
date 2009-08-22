using developwithpassion.commons.core.infrastructure.containers;

namespace nothinbutdotnetstore.infrastructure
{
    public class MapperRegistryImplmentation : MapperRegistry
    {
        public Mapper<Input, Output> get_mapper_to_map<Input, Output>()
        {
            return IOC.get().instance_of<Mapper<Input, Output>>();
        }
    }
}