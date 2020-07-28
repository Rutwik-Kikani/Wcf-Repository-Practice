using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FaultDemoService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class DivideService : IDivideService
    {
        public int DivideTwoInteger(int n1, int n2)
        {
            try
            {
                return n1 / n2;
            }
            catch
            {
                throw new Exception("Service Was Enable To Divide By Zero. Arybhata Error");
            }
            
        }
    }
}
