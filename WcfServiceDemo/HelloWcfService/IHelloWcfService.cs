using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HelloWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IHelloWcfService" in both code and config file together.
    [ServiceContract (Name = "IHelloWcfService")]
    public interface IHelloWcfServiceChanges
    {
        [OperationContract (Name = "GetMessage")]
        string GetMessage(string name);
    }
}
