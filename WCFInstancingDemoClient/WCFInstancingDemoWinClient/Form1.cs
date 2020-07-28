using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCFInstancingDemoWinClient
{
    public partial class Form1 : Form
    {
        SWcfService.SWcfServiceClient client;
        public Form1()
        {
            InitializeComponent();
            client = new SWcfService.SWcfServiceClient();
        }

        private void btnInvokeService_Click(object sender, EventArgs e)
        {
            try
            {
                lblCounter.Text = "Counter :" + client.IncrementCount().ToString() + "\n" +
                    "Session Id : " + client.InnerChannel.SessionId;    
            }catch(System.ServiceModel.CommunicationException)
            {
                MessageBox.Show("Session Time out. Your exsiting session has lost" +
                    "Your new session is Created");
                client = new SWcfService.SWcfServiceClient();
            }
        }
    }
}
