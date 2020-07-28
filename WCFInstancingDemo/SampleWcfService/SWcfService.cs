using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SampleWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior (InstanceContextMode = InstanceContextMode.PerSession)]
    public class SWcfService : ISWcfService
    {
        private int _counter;
        public int IncrementCount()
        {
            Console.WriteLine("Session id :" + OperationContext.Current.SessionId);
            _counter = _counter + 1;
            return _counter;
        }
    }
}
