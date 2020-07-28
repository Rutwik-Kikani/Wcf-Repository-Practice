using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MEPHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(MEPService.MEPService1)))
            {
                host.Open();
                Console.WriteLine("Host Started At "+DateTime.Now.ToShortDateString());
                Console.ReadLine();
            }
        }
    }
}
