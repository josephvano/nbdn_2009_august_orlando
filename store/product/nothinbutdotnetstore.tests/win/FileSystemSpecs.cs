using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using developwithpassion.bdd.contexts;
using developwithpassion.bdd.mbunit;
using developwithpassion.bdd.mbunit.standard.observations;
using developwithpassion.bdddoc.core;
using nothinbutdotnetstore.tests.utility;
using nothinbutdotnetstore.win.core;
using developwithpassion.bdddoc.utility;
using System.Linq;

namespace nothinbutdotnetstore.tests.win
{
    public class FileSystemSpecs
    {
        public abstract class concern :
            observations_for_a_sut_with_a_contract<FileSystem,
                FileSystemImplementation> {}

        [Concern(typeof (FileSystemImplementation))]
        public class when_getting_all_of_the_directories_in_a_directory :
            concern
        {
            context c = () => {

                fake_folder_name = "root";
                                  child_folders =
                                      ObjectMother.create_enumerable_from(
                                          "first", "second", "third");

                add_pipeline_behaviour(create_fake_directory_structure,
                    () => Directory.Delete(path,true));
            };


            static void create_fake_directory_structure()
            {
                var root = Directory.CreateDirectory(path);
                child_folders.each(folder => root.CreateSubdirectory(folder));
            }

            because b = () =>
            {
                results = sut.get_directories(path);
            };

            static string path
            {
                get
                {
                    return Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                                        fake_folder_name);
                }
            }

            it
                should_return_a_set_of_names_of_all_the_directories_in_that_directory
                    = () =>
                    {
                        results.Count().should_be_equal_to(3);
                    };

            static string fake_folder_name;
            static IEnumerable<string> results;
            static IEnumerable<string> child_folders;
        }
    }
}