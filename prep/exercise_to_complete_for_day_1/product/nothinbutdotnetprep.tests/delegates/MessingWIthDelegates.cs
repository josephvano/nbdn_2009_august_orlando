using System;
using developwithpassion.bdd.contexts;
using developwithpassion.bdd.mbunit.standard.observations;
using developwithpassion.bdddoc.core;

namespace nothinbutdotnetprep.tests.delegates
{
    public class MessingWIthDelegates
    {
        public abstract class concern : observations_for_a_static_sut {}

        [Concern(typeof (Delegate))]
        public class when_observation_name : concern
        {
            context c = () => {};

            because b = () => {};


            public delegate TProperty PropertyAccessor<TItem, TProperty>(
                TItem item);

            it first_observation = () =>
            {
                var person = new Person {name = "JP", age = 30};

                PropertyAccessor<Person, string> name_accessor = delegate
                {
                    display_the_name_of(person);
                    return string.Empty;
                };

                Console.Out.WriteLine(name_accessor(null));
            };

            static void display_the_name_of(Person person)
            {
                Console.Out.WriteLine(person.name);
                Console.Out.WriteLine(person.age);
            }

            static public string get_name(Person person)
            {
                return person.name;
            }
        }

        public class Person
        {
            public string name { get; set; }
            public int age { get; set; }
        }
    }
}