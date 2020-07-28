using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CustomFaultDemoService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IDivideService
    {
        [OperationContract]
        [FaultContract(typeof(MathFault))]
        int DivideTwoInteger(int n1, int n2);
    }

    [DataContract]
    public class MathFault
    {
        private string _operation;
        private string _problemType;

        [DataMember]
        public string Operation
        {
            get { return _operation; }
            set { this._operation = value; }
        }

        [DataMember]
        public string ProblemType
        {
            get { return _problemType; }
            set { this._problemType = value; }
        }
    }
}

