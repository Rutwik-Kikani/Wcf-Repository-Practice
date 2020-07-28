using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace MEPService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MEPService1 : IMEPService1
    {
        public string RequestReplyOperation()
        {
            DateTime dtStarted = DateTime.Now;

            //sleep this process for 2s
            Thread.Sleep(2000);

            DateTime dtEnded = DateTime.Now;

            return dtEnded.Subtract(dtStarted).Seconds.ToString() + " Seconds is processing time!!";


        }

        public string RequestReplyOperation_ThrowsException()
        {
            throw new NotImplementedException();
        }

        public void OnyWayOperation()
        {
            Thread.Sleep(2500);
        }

        public void OneWayOperation_ThrowsException()
        {
            throw new NotImplementedException();
        }
    }
}
