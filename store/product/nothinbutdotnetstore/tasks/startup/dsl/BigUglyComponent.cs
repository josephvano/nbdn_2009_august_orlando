using System;
using System.Collections.Generic;
using System.Linq;
using nothinbutdotnetstore.infrastructure;

namespace nothinbutdotnetstore.tasks.startup.dsl
{
    public class BigUglyComponent
    {
        ReallyMessyDependencyThatTalksToDatabase messy_dependency_that_talks_to_database;
        public List<int> some_list { get; private set; }
        public BigUglyComponent() : this(new ReallyMessyDependencyThatTalksToDatabase()) {}

        public BigUglyComponent(ReallyMessyDependencyThatTalksToDatabase messy_dependency_that_talks_to_database)
        {
            this.messy_dependency_that_talks_to_database = messy_dependency_that_talks_to_database;
        }

        public void some_really_untestable_method()
        {
            some_list = new List<int>();

            Enumerable.Range(1, 20).each(item => some_list.Add(item));


            messy_dependency_that_talks_to_database.do_something();
        }
    }


    public class ReallyMessyDependencyThatTalksToDatabase  
    {
        public virtual void do_something()
        {
            throw new NotImplementedException();
        }
    }
}