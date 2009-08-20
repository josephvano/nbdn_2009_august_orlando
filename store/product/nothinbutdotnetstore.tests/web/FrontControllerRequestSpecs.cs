using System.Collections.Specialized;
using developwithpassion.bdd.contexts;
using developwithpassion.bdd.mbunit;
using developwithpassion.bdd.mbunit.standard.observations;
using developwithpassion.bdddoc.core;
using nothinbutdotnetstore.dto;
using nothinbutdotnetstore.infrastructure;
using nothinbutdotnetstore.web.core;
using Rhino.Mocks;

namespace nothinbutdotnetstore.tests.web
{
    public class FrontControllerRequestSpecs
    {
        public abstract class concern :
            observations_for_a_sut_with_a_contract<FrontControllerRequest,
                FrontControllerRequestImplementation> {}

        [Concern(typeof (FrontControllerRequestImplementation))]
        public class when_mapping_an_item : concern
        {
            context c = () =>
            {
                query_string = new NameValueCollection();
                mapper_registry = the_dependency<MapperRegistry>();
                mapper = an<Mapper<NameValueCollection, DepartmentItem>>();
                mapped_item = new DepartmentItem();

                mapper_registry.Stub(
                    x =>
                    x.get_mapper_to_map<NameValueCollection, DepartmentItem>()).
                    Return(mapper);
                mapper.Stub(x => x.map_from(query_string)).Return(mapped_item);
            };

            because b = () =>
            {
                result = sut.map<DepartmentItem>();
            };


            it should_map_the_item_using_the_mapper_for_the_input_model = () =>
            {
                result.should_be_equal_to(mapped_item);
            };

            static DepartmentItem result;
            static DepartmentItem mapped_item;
            static NameValueCollection query_string;
            static MapperRegistry mapper_registry;
            static Mapper<NameValueCollection, DepartmentItem> mapper;
        }
    }
}