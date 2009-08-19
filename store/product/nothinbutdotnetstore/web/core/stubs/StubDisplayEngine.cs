using System.Web;

namespace nothinbutdotnetstore.web.core.stubs
{
    public class StubDisplayEngine : DisplayEngine
    {
        public void display<T>(T item)
        {
            HttpContext.Current.Items.Add("blah", item);
            HttpContext.Current.Server.Transfer("DepartmentBrowser.aspx");

            //BuildManager.CreateInstanceFromVirtualPath("path", type
        }
    }
}