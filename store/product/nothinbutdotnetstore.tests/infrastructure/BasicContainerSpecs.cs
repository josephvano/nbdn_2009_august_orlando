using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using developwithpassion.bdd.contexts;
using developwithpassion.bdd.mbunit;
using developwithpassion.bdd.mbunit.standard.observations;
using developwithpassion.bdddoc.core;
using developwithpassion.commons.core.infrastructure.containers;
using nothinbutdotnetstore.infrastructure.containers.basic;
using Rhino.Mocks;

namespace nothinbutdotnetstore.tests.infrastructure
{
    public class BasicContainerSpecs
    {
        public abstract class concern :
            observations_for_a_sut_with_a_contract<Container,
                BasicContainer>
        {
            context c = () =>
            {
                type_resolvers = new Dictionary<Type, Resolver>();
                provide_a_basic_sut_constructor_argument(type_resolvers);
            };

            static protected IDictionary<Type, Resolver> type_resolvers;
        }

        [Concern(typeof (BasicContainer))]
        public class
            when_getting_an_instance_of_a_dependency_and_there_is_a_resolver_for_that_dependency :
                concern
        {
            context c = () =>
            {
                sql_connection = new SqlConnection();
                connection_resolver = an<Resolver>();

                type_resolvers.Add(typeof (IDbConnection), connection_resolver);
                connection_resolver.Stub(x => x.resolve()).Return(sql_connection);
            };

            because b = () =>
            {
                result = sut.instance_of<IDbConnection>();
            };


            it
                should_return_the_dependency_that_was_resolved_using_the_types_resolver
                    =
                    () => result.should_be_equal_to(sql_connection);

            static IDbConnection result;
            static SqlConnection sql_connection;
            static Resolver connection_resolver;
        }

        [Concern(typeof (BasicContainer))]
        public class
            when_getting_an_instance_of_a_dependency_and_there_is_not_a_resolver_for_the_dependency_type :
                concern
        {
            because b = () =>
            {
                doing(() => sut.instance_of<IDbConnection>());
            };

            it should_throw_an_unregistered_type_exception =
                () =>
                {
                    exception_thrown_by_the_sut.should_be_an
                        <UnregisteredTypeException>()
                        .type_that_has_no_resolver_registered.should_be_equal_to(typeof(IDbConnection));
                };

            static IDbConnection result;
            static SqlConnection sql_connection;
            static Resolver connection_resolver;
        }
    }
}