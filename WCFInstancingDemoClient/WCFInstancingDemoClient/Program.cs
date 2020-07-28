using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFInstancingDemoClient
{
    class Program
    {
        static void Main(string[] args)
        {
            SWcfService.SWcfServiceClient client =
                new SWcfService.SWcfServiceClient();
            //new SWcfService.SWcfServiceClient("BasicHttpBinding_ISWcfService");

            int number = client.IncrementCount();
            Console.WriteLine("First Call " + number);
            number = client.IncrementCount();
            Console.WriteLine("Second Call " + number);
            number = client.IncrementCount();
            Console.WriteLine("Third Call " + number);
            Console.ReadLine();
        }
    }
}
