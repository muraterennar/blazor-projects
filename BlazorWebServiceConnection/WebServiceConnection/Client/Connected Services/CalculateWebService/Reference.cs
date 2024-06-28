﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculateWebService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculateWebService.CalculatorSoap")]
    public interface CalculatorSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<CalculateWebService.AddResponse> AddAsync(CalculateWebService.AddRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Subtract", ReplyAction="*")]
        System.Threading.Tasks.Task<CalculateWebService.SubtractResponse> SubtractAsync(CalculateWebService.SubtractRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiply", ReplyAction="*")]
        System.Threading.Tasks.Task<CalculateWebService.MultiplyResponse> MultiplyAsync(CalculateWebService.MultiplyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Divide", ReplyAction="*")]
        System.Threading.Tasks.Task<CalculateWebService.DivideResponse> DivideAsync(CalculateWebService.DivideRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Add", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AddRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int intA;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int intB;
        
        public AddRequest()
        {
        }
        
        public AddRequest(int intA, int intB)
        {
            this.intA = intA;
            this.intB = intB;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AddResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int AddResult;
        
        public AddResponse()
        {
        }
        
        public AddResponse(int AddResult)
        {
            this.AddResult = AddResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Subtract", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SubtractRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int intA;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int intB;
        
        public SubtractRequest()
        {
        }
        
        public SubtractRequest(int intA, int intB)
        {
            this.intA = intA;
            this.intB = intB;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SubtractResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class SubtractResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int SubtractResult;
        
        public SubtractResponse()
        {
        }
        
        public SubtractResponse(int SubtractResult)
        {
            this.SubtractResult = SubtractResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Multiply", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class MultiplyRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int intA;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int intB;
        
        public MultiplyRequest()
        {
        }
        
        public MultiplyRequest(int intA, int intB)
        {
            this.intA = intA;
            this.intB = intB;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="MultiplyResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class MultiplyResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int MultiplyResult;
        
        public MultiplyResponse()
        {
        }
        
        public MultiplyResponse(int MultiplyResult)
        {
            this.MultiplyResult = MultiplyResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Divide", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DivideRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int intA;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int intB;
        
        public DivideRequest()
        {
        }
        
        public DivideRequest(int intA, int intB)
        {
            this.intA = intA;
            this.intB = intB;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DivideResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DivideResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int DivideResult;
        
        public DivideResponse()
        {
        }
        
        public DivideResponse(int DivideResult)
        {
            this.DivideResult = DivideResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface CalculatorSoapChannel : CalculateWebService.CalculatorSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class CalculatorSoapClient : System.ServiceModel.ClientBase<CalculateWebService.CalculatorSoap>, CalculateWebService.CalculatorSoap
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CalculatorSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(CalculatorSoapClient.GetBindingForEndpoint(endpointConfiguration), CalculatorSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CalculatorSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CalculatorSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CalculatorSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CalculatorSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CalculatorSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }

        //public CalculatorSoapClient()
        //{
        //}

        public System.Threading.Tasks.Task<CalculateWebService.AddResponse> AddAsync(CalculateWebService.AddRequest request)
        {
            return base.Channel.AddAsync(request);
        }
        
        public System.Threading.Tasks.Task<CalculateWebService.SubtractResponse> SubtractAsync(CalculateWebService.SubtractRequest request)
        {
            return base.Channel.SubtractAsync(request);
        }
        
        public System.Threading.Tasks.Task<CalculateWebService.MultiplyResponse> MultiplyAsync(CalculateWebService.MultiplyRequest request)
        {
            return base.Channel.MultiplyAsync(request);
        }
        
        public System.Threading.Tasks.Task<CalculateWebService.DivideResponse> DivideAsync(CalculateWebService.DivideRequest request)
        {
            return base.Channel.DivideAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.CalculatorSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.CalculatorSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.CalculatorSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://www.dneonline.com/calculator.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.CalculatorSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://www.dneonline.com/calculator.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            CalculatorSoap,
            
            CalculatorSoap12,
        }
    }
}
