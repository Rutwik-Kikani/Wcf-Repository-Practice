using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplexMEPDmoClient
{
    [CallbackBehavior(UseSynchronizationContext = false)]
    public partial class Form1 : Form,ReportServiceHttp.IReportServiceCallback
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Process(int percentageComplete)
        {
            CheckForIllegalCrossThreadCalls = false;
            textBox1.Text = percentageComplete.ToString() + "% completed";
        }

        private void btnProcessReport_Click(object sender, EventArgs e)
        {
            InstanceContext instanceContext = new InstanceContext(this);
            ReportServiceHttp.ReportServiceClient client = 
                new ReportServiceHttp.ReportServiceClient(instanceContext);
            client.ProcessReport();
        }
    }
}
