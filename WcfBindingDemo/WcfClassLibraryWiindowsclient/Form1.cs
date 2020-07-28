using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfClassLibraryWiindowsclient.DumWcfServiceTcp;

namespace WcfClassLibraryWiindowsclient
{
    public partial class Form1 : Form
    {
        private int _selection = 0 ;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetText_Click(object sender, EventArgs e)
        {
            switch (_selection)
            {
                case 0:
                {
                    DumWcfServiceTcp.DumWcfServiceClient tcpClient = new DumWcfServiceTcp.DumWcfServiceClient("NetTcpBinding_IDumWcfService");
                    lblText.Text = tcpClient.GetText()+" from TcpClient";
                } break;
                case 1:
                {
                    DumWcfServicePipe.DumWcfServiceClient pipeClient = new DumWcfServicePipe.DumWcfServiceClient("NetNamedPipeBinding_IDumWcfService");
                    lblText.Text = pipeClient.GetText()+" from pipeClient";
                } break;
                case 2: 
                {
                    DumWcfServiceHttp.DumWcfServiceClient httpClient = new DumWcfServiceHttp.DumWcfServiceClient("BasicHttpBinding_IDumWcfService");
                    lblText.Text = httpClient.GetText() + " from httpClient";
                } break;
                    

            }
            
        }

        private void btnMulInterger_Click(object sender, EventArgs e)
        {
            switch (_selection)
            {
                case 0:
                    {
                        DumWcfServiceTcp.DumWcfServiceClient tcpClient = new DumWcfServiceTcp.DumWcfServiceClient("NetTcpBinding_IDumWcfService");
                        lblMultiplication.Text = "Multiplication of 11 and 12 is : " + tcpClient.MultiplyTwoInteger(11, 12).ToString()+" from TcpClient";
                    }break;
                case 1:
                    {
                        DumWcfServicePipe.DumWcfServiceClient pipeClient  = new DumWcfServicePipe.DumWcfServiceClient("NetNamedPipeBinding_IDumWcfService");
                        lblMultiplication.Text = "Multiplication of 11 and 12 is : " + pipeClient.MultiplyTwoInteger(11, 12).ToString()+" from pipeClient";
                    }break;
                case 2:
                    {
                        DumWcfServiceHttp.DumWcfServiceClient httpClient = new DumWcfServiceHttp.DumWcfServiceClient("BasicHttpBinding_IDumWcfService");
                        lblMultiplication.Text = "Multiplication of 11 and 12 is : " + httpClient.MultiplyTwoInteger(11, 12).ToString() + " from httpClient";
                    } break;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            _selection = 0;
            lblMultiplication.Text = null;
            lblText.Text = null;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _selection = 1;
            lblMultiplication.Text = null;
            lblText.Text = null;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            _selection = 2;
            lblMultiplication.Text = null;
            lblText.Text = null;
        }
    }
}
