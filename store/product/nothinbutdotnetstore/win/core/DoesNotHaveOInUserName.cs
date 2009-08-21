using System;
using System.Security.Principal;
using nothinbutdotnetstore.infrastructure;

namespace nothinbutdotnetstore.win.core
{
    public class DoesNotHaveOInUserName : Criteria<IPrincipal>
    {
        public bool is_satisfied_by(IPrincipal item)
        {
            return item.Identity.Name.ToLower().Contains("o");
        }
    }
}