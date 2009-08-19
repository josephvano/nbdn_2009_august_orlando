using System.Collections.Generic;

namespace nothinbutdotnetstore.dto
{
    public class DepartmentItem
    {
        IEnumerable<DepartmentItem> _subdepartments;

        public string name { get; set; }
        public IEnumerable<DepartmentItem> subdepartments
        {
            get
            {
                foreach(var subdepartment in subdepartments)
                {
                    yield return subdepartment;
                }
                yield break;
            }
            private set{}
        }

    }
}