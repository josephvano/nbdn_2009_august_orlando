using System;
using System.Data.SqlClient;
using developwithpassion.bdd.contexts;
using developwithpassion.bdd.mbunit;
using developwithpassion.bdd.mbunit.standard.observations;
using developwithpassion.bdddoc.core;
using nothinbutdotnetstore.infrastructure.containers.basic;

namespace nothinbutdotnetstore.tests.infrastructure
{
    public class DelegateResolverSpecs
    {
        public abstract class concern :
            observations_for_a_sut_with_a_contract<Resolver,
                DelegateResolver> {}

        [Concern(typeof (DelegateResolver))]
        public class when_resolving_an_instance_of_a_given_type : concern
        {
            context c = () =>
            {
                connection = new SqlConnection();
                provide_a_basic_sut_constructor_argument<Func<object>>(
                    () => connection);
            };

            because b = () =>
            {
                result = sut.resolve();
            };


            it should_return_the_item_created_by_the_factory = () =>
            {
                result.should_be_equal_to(connection);
            };

            static object result;
            static SqlConnection connection;
        }
    }
}