using nothinbutdotnetstore.dto;
using nothinbutdotnetstore.tasks;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.web.application
{
    public class ViewSubdepartmentsInDepartment : ApplicationCommand
    {
        CatalogTasks catalog_tasks;
        DisplayEngine display_engine;

        public ViewSubdepartmentsInDepartment(CatalogTasks catalog_tasks, DisplayEngine display_engine)
        {
            this.catalog_tasks = catalog_tasks;
            this.display_engine = display_engine;
        }

        public void process(FrontControllerRequest request)
        {
            display_engine.display(
                catalog_tasks.get_all_subdepartments_in(
                    request.map<DepartmentItem>()));
        }
    }
}