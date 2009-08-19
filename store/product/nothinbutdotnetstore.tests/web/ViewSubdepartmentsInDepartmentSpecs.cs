 using System.Collections.Generic;
 using System.Linq;
 using developwithpassion.bdd;
 using developwithpassion.bdd.contexts;
 using developwithpassion.bdd.mbunit.standard.observations;
 using developwithpassion.bdddoc.core;
 using nothinbutdotnetstore.dto;
 using nothinbutdotnetstore.tasks;
 using nothinbutdotnetstore.web.application;
 using nothinbutdotnetstore.web.core;
 using Rhino.Mocks;

namespace nothinbutdotnetstore.tests.web
 {   
     public class ViewSubdepartmentsInDepartmentSpecs
     {
         public abstract class concern : observations_for_a_sut_with_a_contract<ApplicationCommand,
                                             ViewSubdepartmentsInDepartment>
         {
        
         }

         [Concern(typeof(ViewSubdepartmentsInDepartment))]
         public class when_displaying_subdepartments_in_a_department : concern
         {
             context c = () =>
             {
                 catalog_tasks = the_dependency<CatalogTasks>();
                 display_engine = the_dependency<DisplayEngine>();
                 request = an<FrontControllerRequest>();
                 parent_department = an<DepartmentItem>();
                 child_departments = Enumerable.Range(1, 5).Select(
                     department_item => an<DepartmentItem>());


                 request.Stub(x => x.map<DepartmentItem>()).Return(
                     parent_department);

                 catalog_tasks.Stub(x => x.get_all_subdepartments_in(parent_department))
                     .Return(child_departments);
             };

             because b = () =>
             {
                sut.process(request);
             };

        
             it should_display_subdepartments_in_the_department = () =>
             {
                 display_engine.received(x => x.display(child_departments));
             };

             static CatalogTasks catalog_tasks;
             static FrontControllerRequest request;
             static DepartmentItem parent_department;
             static IEnumerable<DepartmentItem> child_departments;
             static DisplayEngine display_engine;
         }
     }
 }
