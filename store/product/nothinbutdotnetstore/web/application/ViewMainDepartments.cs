using nothinbutdotnetstore.tasks;
using nothinbutdotnetstore.tasks.stubs;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.web.application
{
    public class ViewMainDepartments : ApplicationCommand
    {
        CatalogTasks catalog_tasks;
        DisplayEngine display_engine;

        public ViewMainDepartments() : this(new StubCatalogTasks(),
                                            new HtmlDisplayEngine(new StubViewRegistry())) {}


        public ViewMainDepartments(CatalogTasks catalogTask,
                                   DisplayEngine displayEngine)
        {
            catalog_tasks = catalogTask;
            display_engine = displayEngine;
        }

        public void process(FrontControllerRequest request)
        {
            display_engine.display(catalog_tasks.get_all_main_departments());
        }
    }
}