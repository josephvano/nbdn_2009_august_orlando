using System;
using System.Collections.Generic;
using developwithpassion.bdd.contexts;
using developwithpassion.bdd.mbunit.standard.observations;
using developwithpassion.bdddoc.core;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.tests.web
{
    public class HtmlSpecs
    {
        public abstract class concern : observations_for_a_static_sut {}

        [Concern(typeof (HtmlHelper))]
        public class when_given_a_list_of_items : concern
        {
            context c = () =>
            {
                test_list = new List<string>();
                test_list.Add("one");
                test_list.Add("two");
            };

            because b = () => {};


            it it_should_enumerate_the_list = () =>
            {
                test_list.list(x => Console.WriteLine("test-{0}",x) );
            };

            static List<string> test_list;
        }
    }
}