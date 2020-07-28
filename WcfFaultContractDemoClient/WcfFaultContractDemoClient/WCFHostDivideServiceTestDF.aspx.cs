using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WcfFaultContractDemoClient.WCFHostDivideServcie;

namespace WcfFaultContractDemoClient
{
    public partial class WCFHostDivideServiceTestDF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WCFHostDivideServcie.DivideServiceClient client = 
                new DivideServiceClient();
            Response.Write(client.DivideTwoInteger(20,0));
        }
    }
}