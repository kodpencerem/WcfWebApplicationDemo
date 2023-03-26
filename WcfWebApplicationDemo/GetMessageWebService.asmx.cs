using System.Web.Services;

namespace WcfWebApplicationDemo
{
    /// <summary>
    /// Summary description for GetMessageWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class GetMessageWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string GetMessage(string name)
        {
            return "Hello " + name;
        }
    }
}
