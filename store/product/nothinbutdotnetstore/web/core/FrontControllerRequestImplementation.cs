using System.Collections.Specialized;
using nothinbutdotnetstore.infrastructure;

namespace nothinbutdotnetstore.web.core
{
    public class FrontControllerRequestImplementation : FrontControllerRequest
    {
        MapperRegistry mapper_registry;
        NameValueCollection query_string;

        public FrontControllerRequestImplementation(
            MapperRegistry mapper_registry, NameValueCollection query_string)
        {
            this.mapper_registry = mapper_registry;
            this.query_string = query_string;
        }

        public InputModel map<InputModel>()
        {
            return
                mapper_registry.get_mapper_to_map
                    <NameValueCollection, InputModel>().
                    map_from(query_string);
        }
    }
}