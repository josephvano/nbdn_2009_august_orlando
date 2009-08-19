using System.Collections.Generic;
using System.Linq;
using nothinbutdotnetstore.dto;

namespace nothinbutdotnetstore.tasks.stubs
{
    public class StubCatalogTasks : CatalogTasks
    {
        public IEnumerable<DepartmentItem> get_all_main_departments()
        {
            return
                Enumerable.Range(1, 10).Select(
                    number =>
                    new DepartmentItem {name = number.ToString("Department 0")});
        }
    }
}