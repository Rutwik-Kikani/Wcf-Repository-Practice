using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CustomeFaultDemoClient.DivideService;

namespace CustomeFaultDemoClient
{
    public partial class DivideServiceTestDF : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDivide_Click(object sender, EventArgs e)
        {
            DivideService.DivideServiceClient client = 
                new DivideService.DivideServiceClient("WSHttpBinding_IDivideService");

            try
            {
                int result = client.DivideTwoInteger(int.Parse(tbNumOne.Text), int.Parse(tbNumTwo.Text));
                tbResult.Text = result.ToString();
            }
            catch (TimeoutException tEx)
            {
                Response.Write("The host Operation time out" + tEx.Message);
                client.Abort();
            }
            catch (FaultException<DivideService.MathFault> mathFault)
            {
                lblException.Text = mathFault.Detail + " caused " + mathFault.Detail.ProblemType;
            }
            catch (FaultException unknown)
            {
                Response.Write("An Unknown Exception Occur " + unknown.Message);
                client.Abort();
            }
            catch (CommunicationException comEx)
            {
                Response.Write("There is A Communication Problem "+comEx.Message+comEx.StackTrace);
                client.Abort();
            }
        }
    }
}