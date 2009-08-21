using System.Security.Principal;
using System.Threading;
using nothinbutdotnetstore.infrastructure;

namespace nothinbutdotnetstore.win.core
{
    public class SecuringCommand : Command
    {
        Command to_secure;
        Criteria<IPrincipal> criteria;

        public SecuringCommand(Command to_secure, Criteria<IPrincipal> criteria)
        {
            this.to_secure = to_secure;
            this.criteria = criteria;
        }

        public void run()
        {
            if (criteria.is_satisfied_by(Thread.CurrentPrincipal))
                to_secure.run();
        }
    }
}