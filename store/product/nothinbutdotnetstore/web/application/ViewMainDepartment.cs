using System;
using nothinbutdotnetstore.tasks;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.web.application
{
    public class ViewMainDepartment : ApplicationCommand
    {
        CatalogTasks catalog_task;
        DisplayEngine display_engine;

        public ViewMainDepartment(CatalogTasks catalogTask, DisplayEngine displayEngine)
        {
            catalog_task = catalogTask;
            display_engine = displayEngine;
        }

        public void process(FrontControllerRequest request)
        {
            var main_departments = catalog_task.get_all_main_departments();
            display_engine.display(main_departments);
        }
    }
}