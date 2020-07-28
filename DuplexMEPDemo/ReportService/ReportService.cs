using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace ReportService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    //[ServiceBehavior (ConcurrencyMode = ConcurrencyMode.Reentrant)]
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class ReportService : IReportService
    {
        public void ProcessReport()
        {
            for (int i = 1; i <= 100; i++)
            {
                //Some logic to process report
                Thread.Sleep(100);
                //Get call bck channel to sent message to the client
                OperationContext.Current
                    .GetCallbackChannel<IReportServiceCallback>().Process(i);
            }
        }
    }
}
