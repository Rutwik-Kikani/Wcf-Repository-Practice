﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MEPDemoClient.MEPServiceHttp {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MEPServiceHttp.IMEPService1")]
    public interface IMEPService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMEPService1/RequestReplyOperation", ReplyAction="http://tempuri.org/IMEPService1/RequestReplyOperationResponse")]
        string RequestReplyOperation();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMEPService1/RequestReplyOperation", ReplyAction="http://tempuri.org/IMEPService1/RequestReplyOperationResponse")]
        System.Threading.Tasks.Task<string> RequestReplyOperationAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMEPService1/RequestReplyOperation_ThrowsException", ReplyAction="http://tempuri.org/IMEPService1/RequestReplyOperation_ThrowsExceptionResponse")]
        string RequestReplyOperation_ThrowsException();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMEPService1/RequestReplyOperation_ThrowsException", ReplyAction="http://tempuri.org/IMEPService1/RequestReplyOperation_ThrowsExceptionResponse")]
        System.Threading.Tasks.Task<string> RequestReplyOperation_ThrowsExceptionAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMEPService1/OnyWayOperation")]
        void OnyWayOperation();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMEPService1/OnyWayOperation")]
        System.Threading.Tasks.Task OnyWayOperationAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMEPService1/OneWayOperation_ThrowsException")]
        void OneWayOperation_ThrowsException();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IMEPService1/OneWayOperation_ThrowsException")]
        System.Threading.Tasks.Task OneWayOperation_ThrowsExceptionAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMEPService1Channel : MEPDemoClient.MEPServiceHttp.IMEPService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MEPService1Client : System.ServiceModel.ClientBase<MEPDemoClient.MEPServiceHttp.IMEPService1>, MEPDemoClient.MEPServiceHttp.IMEPService1 {
        
        public MEPService1Client() {
        }
        
        public MEPService1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MEPService1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MEPService1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MEPService1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string RequestReplyOperation() {
            return base.Channel.RequestReplyOperation();
        }
        
        public System.Threading.Tasks.Task<string> RequestReplyOperationAsync() {
            return base.Channel.RequestReplyOperationAsync();
        }
        
        public string RequestReplyOperation_ThrowsException() {
            return base.Channel.RequestReplyOperation_ThrowsException();
        }
        
        public System.Threading.Tasks.Task<string> RequestReplyOperation_ThrowsExceptionAsync() {
            return base.Channel.RequestReplyOperation_ThrowsExceptionAsync();
        }
        
        public void OnyWayOperation() {
            base.Channel.OnyWayOperation();
        }
        
        public System.Threading.Tasks.Task OnyWayOperationAsync() {
            return base.Channel.OnyWayOperationAsync();
        }
        
        public void OneWayOperation_ThrowsException() {
            base.Channel.OneWayOperation_ThrowsException();
        }
        
        public System.Threading.Tasks.Task OneWayOperation_ThrowsExceptionAsync() {
            return base.Channel.OneWayOperation_ThrowsExceptionAsync();
        }
    }
}
