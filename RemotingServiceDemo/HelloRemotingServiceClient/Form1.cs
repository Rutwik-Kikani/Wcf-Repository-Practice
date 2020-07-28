using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloRemotingServiceClient
{
    public partial class Form1 : Form
    {
        private IHelloRemotingService.IHelloRemotingService client;
        public Form1()
        {
            InitializeComponent();
            TcpChannel channel = new TcpChannel();
#pragma warning disable 618
            ChannelServices.RegisterChannel(channel);
#pragma warning restore 618
            client = (IHelloRemotingService.IHelloRemotingService) Activator.GetObject(
                typeof(IHelloRemotingService.IHelloRemotingService), "tcp://localhost:8080/GetMessage");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = client.GetMessage(textBox1.Text);
        }
    }
}
