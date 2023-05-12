using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServices
{
    /// <summary>
    /// Summary description for TempEmail
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TryNew : System.Web.Services.WebService
    {
        static string myEmail = "";

        private static string MyEmail { get => myEmail; set => myEmail = value; }
        [WebMethod]
        public string GetEmail()
        {
            return MyEmail;
        }
        [WebMethod]
        public void SetEmail(string email)
        {
            myEmail = email;
        }
    }
}
