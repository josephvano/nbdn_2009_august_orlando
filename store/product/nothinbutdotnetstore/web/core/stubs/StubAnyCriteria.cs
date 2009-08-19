using nothinbutdotnetstore.infrastructure;

namespace nothinbutdotnetstore.web.core.stubs
{
    public class StubAnyCriteria : Criteria<FrontControllerRequest>
    {
        public bool is_satisfied_by(FrontControllerRequest item)
        {
            return true;
        }
    }
}