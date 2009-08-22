using System;
using System.Linq;
using System.Reflection;
using developwithpassion.bdd.contexts;
using developwithpassion.bdd.mbunit.standard.observations;
using developwithpassion.bdddoc.core;
using nothinbutdotnetstore.tasks.startup.dsl;
using nothinbutdotnetstore.infrastructure;

namespace nothinbutdotnetstore.tests.utility.conventions
{
    public class EnsureAllApplicationConventionsAreBeingFollowed
    {
        public abstract class concern : observations_for_a_static_sut {}

        [Concern(typeof (EnsureAllApplicationConventionsAreBeingFollowed))]
        public class when_a_startup_command_exists_in_the_application_assembly : concern
        {
            it should_have_a_constructor_that_takes_all_the_required_dependencies_for_the_convention = () =>
            {
                typeof(ApplicationConvention).Assembly.GetTypes()
                    .Where(new IsAnApplicationConvention().is_satisfied_by)
                    .Select(type => Activator.CreateInstance(type)).Cast<ApplicationConvention>()
                    .each(convention => convention.is_adhered_to_by_all_types_in_assembly_of<StartableBuilder>());
            };
        }
    }

    static public class TypeExtensions
    {
        static public ConstructorInfo greediest_constructor(this Type type)
        {
            return type.GetConstructors().OrderByDescending(x => x.GetParameters().Count())
                .First();
        }
    }
}