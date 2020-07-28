using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace RemotingServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating service instance
            HelloRemotingService.HelloRemotingService remotingService = new HelloRemotingService.HelloRemotingService();

            //create channel
            TcpChannel channel = new TcpChannel(8080);

            //register channel
#pragma warning disable 618
            ChannelServices.RegisterChannel(channel);
#pragma warning restore 618

            //config channel
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(HelloRemotingService.HelloRemotingService), "GetMessage", WellKnownObjectMode.Singleton);

            Console.WriteLine("Host Started At "+DateTime.Now.ToString());
            Console.ReadLine();
        }
    }
}
