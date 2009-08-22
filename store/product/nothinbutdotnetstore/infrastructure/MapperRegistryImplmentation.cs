using System;

namespace nothinbutdotnetstore.infrastructure
{
    public class MapperRegistryImplmentation : MapperRegistry
    {
        public Mapper<Input, Output> get_mapper_to_map<Input, Output>()
        {
            throw new NotImplementedException();
        }
    }
}