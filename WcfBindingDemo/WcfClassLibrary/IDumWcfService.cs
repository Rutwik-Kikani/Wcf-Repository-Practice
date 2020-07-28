using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfClassLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDumWcfService" in both code and config file together.
    [ServiceContract]
    public interface IDumWcfService
    {
        [OperationContract]
        string GetText();

        [OperationContract]
        int MultiplyTwoInteger(int firstNum, int secondNum);
    }
}
