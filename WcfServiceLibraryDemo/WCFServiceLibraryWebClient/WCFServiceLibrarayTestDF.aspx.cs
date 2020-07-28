using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WCFServiceLibraryWebClient
{
    public partial class WCFServiceLibrarayTestDF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnGetMessage_Click(object sender, EventArgs e)
        {
            WcfServiceLibrary_Service1.Service1Client client = new WcfServiceLibrary_Service1.Service1Client();
            lblMessage.Text = client.GetData(Convert.ToInt32(tbMessage.Text.ToString()));
        }
    }
}