using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace MEPDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
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
    }
}
