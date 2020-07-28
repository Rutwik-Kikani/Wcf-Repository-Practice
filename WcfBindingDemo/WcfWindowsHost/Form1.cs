using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WcfWindowsHost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Uri tcpAddressUri = new Uri("net.tcp://localhost:8080/TcpBinding");
            Uri pipeAddressUri = new Uri("net.pipe://localhost/NetNamedPipeBinding");
            Uri httpAddressUri = new Uri("http://localhost:8090/HttpBinding");
            ServiceHost host = new ServiceHost(typeof(WcfClassLibrary.DumWcfService),tcpAddressUri,pipeAddressUri,httpAddressUri);
            
            NetNamedPipeBinding pipeBinding = new NetNamedPipeBinding();
            NetTcpBinding tcpBinding = new NetTcpBinding();
            BasicHttpBinding basicHttpBinding = new BasicHttpBinding();
            
            ServiceMetadataBehavior mexBehavior = new ServiceMetadataBehavior();
            host.Description.Behaviors.Add(mexBehavior);

            host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexTcpBinding(), "mex");
            host.AddServiceEndpoint(typeof(IMetadataExchange),
                MetadataExchangeBindings.CreateMexNamedPipeBinding(), "mex");
            host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexHttpBinding(), "mex");
            host.AddServiceEndpoint(typeof(WcfClassLibrary.IDumWcfService), tcpBinding, tcpAddressUri);
            host.AddServiceEndpoint(typeof(WcfClassLibrary.IDumWcfService), pipeBinding, pipeAddressUri);
            host.AddServiceEndpoint(typeof(WcfClassLibrary.IDumWcfService), basicHttpBinding, httpAddressUri);
            
            host.Open();
            lblHostMessage.Text = "Service Has Started....";


        }
    }
}
