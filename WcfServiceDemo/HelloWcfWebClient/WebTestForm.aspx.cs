using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWcfWebClient
{
    public partial class WebTestForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HelloWcfService.HelloWcfServiceClient client = new HelloWcfService.HelloWcfServiceClient("BasicHttpBinding_IHelloWcfService");
            Label1.Text = client.GetMessage(TextBox1.Text);
        }
    }
}