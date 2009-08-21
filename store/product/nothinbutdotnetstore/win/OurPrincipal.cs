using System.Security.Principal;

namespace nothinbutdotnetstore.win
{
    public class OurPrincipal : IPrincipal
    {
        public bool IsInRole(string role)
        {
            return false;
        }

        public IIdentity Identity
        {
            get { return new GenericIdentity("oo7"); }
        }
    }
}