using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace FaultDemoServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(FaultDemoService.DivideService)))
            {
                host.Open();
                Console.WriteLine("Host Started At " + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
