﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AuthenticationWCF_Client.ServiceReferenceClient {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceClient.IServiceHello")]
    public interface IServiceHello {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHello/DoWork", ReplyAction="http://tempuri.org/IServiceHello/DoWorkResponse")]
        string DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceHello/DoWork", ReplyAction="http://tempuri.org/IServiceHello/DoWorkResponse")]
        System.Threading.Tasks.Task<string> DoWorkAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceHelloChannel : AuthenticationWCF_Client.ServiceReferenceClient.IServiceHello, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceHelloClient : System.ServiceModel.ClientBase<AuthenticationWCF_Client.ServiceReferenceClient.IServiceHello>, AuthenticationWCF_Client.ServiceReferenceClient.IServiceHello {
        
        public ServiceHelloClient() {
        }
        
        public ServiceHelloClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceHelloClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceHelloClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceHelloClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string DoWork() {
            return base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task<string> DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
    }
}
