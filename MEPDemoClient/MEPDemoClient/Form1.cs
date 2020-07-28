using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEPDemoClient.MEPServiceHttp;

namespace MEPDemoClient
{
    public partial class Form1 : Form
    {
        private MEPServiceHttp.MEPService1Client client= new MEPService1Client("NetTcpBinding_IMEPService1");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClearData_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btnRequestReplyOperation_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add("Request-Reply Operation started at "
                                   + DateTime.Now.ToString());
                btnRequestReplyOperation.Enabled = false;
                listBox1.Items.Add(client.RequestReplyOperation());
                btnRequestReplyOperation.Enabled = true;
                listBox1.Items.Add("Request-Reply Operation ended at "
                                   + DateTime.Now.ToString());
                listBox1.Items.Add("****************************************");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRequestReplyOperationThrowsException_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add("Request-Reply Throws Exception Operation started at "
                                   + DateTime.Now.ToString());
                btnRequestReplyOperationThrowsException.Enabled = false;
                listBox1.Items.Add(client.RequestReplyOperation_ThrowsException());
                btnRequestReplyOperationThrowsException.Enabled = true;
                listBox1.Items.Add("Request-Reply Throws Exception Operation ended at "
                                   + DateTime.Now.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnOneWayOperation_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add("OneWay Operation started at "
                                   + DateTime.Now.ToString());
                btnRequestReplyOperation.Enabled = false;
                client.OnyWayOperation();
                btnRequestReplyOperation.Enabled = true;
                listBox1.Items.Add("OneWay Operation ended at "
                                   + DateTime.Now.ToString());
                listBox1.Items.Add("****************************************");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnOneWayOperationThrowsException_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Add("OneWay Operation Throws Exception started at "
                                   + DateTime.Now.ToString());
                btnRequestReplyOperation.Enabled = false;
                client.OneWayOperation_ThrowsException();
                btnRequestReplyOperation.Enabled = true;
                listBox1.Items.Add("OneWay Operation Throws Exception ended at "
                                   + DateTime.Now.ToString());
                listBox1.Items.Add("****************************************");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
