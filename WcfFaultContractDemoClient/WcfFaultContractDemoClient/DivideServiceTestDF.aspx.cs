using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WcfFaultContractDemoClient.DivideService;

namespace WcfFaultContractDemoClient
{
    public partial class DivideServiceTestDF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                DivideService.DivideServiceClient client =
                    new DivideServiceClient("WSHttpBinding_IDivideService");
                int result = client.DivideTwoInteger(int.Parse(tbNumOne.Text), int.Parse(tbNumTwo.Text));
                tbResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                lblException.Text = ex.Message;
            }
        }
    }
}