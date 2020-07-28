using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWcfWindowsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HelloWcfService.HelloWcfServiceClient client = new HelloWcfService.HelloWcfServiceClient("NetTcpBinding_IHelloWcfService");
            label1.Text=client.GetMessage(textBox1.Text);
        }
    }
}
