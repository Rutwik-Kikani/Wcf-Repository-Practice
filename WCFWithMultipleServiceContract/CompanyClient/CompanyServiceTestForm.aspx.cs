using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CompanyClient
{
    public partial class CompanyServiceTestForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CompanyService.MyCompanyPublicServiceClient pClient = new 
                CompanyService.MyCompanyPublicServiceClient("BasicHttpBinding_IMyCompanyPublicService");
            Label1.Text = pClient.GetPublicInformation();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            CompanyService.MyCompanyConfidentialServiceClient cClient = new 
                CompanyService.MyCompanyConfidentialServiceClient("NetTcpBinding_IMyCompanyConfidentialService");
            Label2.Text = cClient.GetConfidentialInformation();
        }
    }
}