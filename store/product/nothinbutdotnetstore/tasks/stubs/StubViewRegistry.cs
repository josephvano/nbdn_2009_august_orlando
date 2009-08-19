using System.Collections.Generic;
using nothinbutdotnetstore.dto;
using nothinbutdotnetstore.web.core;

namespace nothinbutdotnetstore.tasks.stubs
{
    public class StubViewRegistry : ViewRegistry
    {
        public View get_view_information_for<Model>()
        {
            return new View
                   {
                       path = "~/views/DepartmentBrowser.aspx",
                       type = typeof (ViewForModel<IEnumerable<DepartmentItem>>)
                   };
        }
    }
}