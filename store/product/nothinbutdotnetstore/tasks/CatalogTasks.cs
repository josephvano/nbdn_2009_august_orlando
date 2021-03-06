using System.Collections.Generic;
using nothinbutdotnetstore.dto;

namespace nothinbutdotnetstore.tasks
{
    public interface CatalogTasks
    {
        IEnumerable<DepartmentItem> get_all_main_departments();
        IEnumerable<DepartmentItem> get_all_subdepartments_in(DepartmentItem main_department);
    }
}