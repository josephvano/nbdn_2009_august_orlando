using System.Linq;
using nothinbutdotnetstore.infrastructure;
using developwithpassion.bdd.mbunit;

namespace nothinbutdotnetstore.tests.utility.conventions
{
    static public class ConventionExtensions {
        public static void is_adhered_to_by_all_types_in_assembly_of<TypeFromAssemblyToCheck>(this ApplicationConvention  convention) {
            typeof(TypeFromAssemblyToCheck).Assembly.GetTypes()
                .Where(convention.applies_to)
                .each(item => convention.is_satisfied_by(item).should_be_true());
                
        }

    }
}