﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinkedU.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://it.ilstu.edu/", ConfigurationName="ServiceReference1.TextSender")]
    public interface TextSender {
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://it.ilstu.edu/TextSender/sendSMSRequest", ReplyAction="http://it.ilstu.edu/TextSender/sendSMSResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LinkedU.ServiceReference1.sendSMSResponse sendSMS(LinkedU.ServiceReference1.sendSMSRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://it.ilstu.edu/TextSender/sendSMSRequest", ReplyAction="http://it.ilstu.edu/TextSender/sendSMSResponse")]
        System.Threading.Tasks.Task<LinkedU.ServiceReference1.sendSMSResponse> sendSMSAsync(LinkedU.ServiceReference1.sendSMSRequest request);
        
        // CODEGEN: Parameter 'return' requires additional schema information that cannot be captured using the parameter mode. The specific attribute is 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="http://it.ilstu.edu/TextSender/getCarriersRequest", ReplyAction="http://it.ilstu.edu/TextSender/getCarriersResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        LinkedU.ServiceReference1.getCarriersResponse getCarriers(LinkedU.ServiceReference1.getCarriersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://it.ilstu.edu/TextSender/getCarriersRequest", ReplyAction="http://it.ilstu.edu/TextSender/getCarriersResponse")]
        System.Threading.Tasks.Task<LinkedU.ServiceReference1.getCarriersResponse> getCarriersAsync(LinkedU.ServiceReference1.getCarriersRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendSMS", WrapperNamespace="http://it.ilstu.edu/", IsWrapped=true)]
    public partial class sendSMSRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://it.ilstu.edu/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string carrier;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://it.ilstu.edu/", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string telephoneNum;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://it.ilstu.edu/", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string text;
        
        public sendSMSRequest() {
        }
        
        public sendSMSRequest(string carrier, string telephoneNum, string text) {
            this.carrier = carrier;
            this.telephoneNum = telephoneNum;
            this.text = text;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="sendSMSResponse", WrapperNamespace="http://it.ilstu.edu/", IsWrapped=true)]
    public partial class sendSMSResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://it.ilstu.edu/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int @return;
        
        public sendSMSResponse() {
        }
        
        public sendSMSResponse(int @return) {
            this.@return = @return;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCarriers", WrapperNamespace="http://it.ilstu.edu/", IsWrapped=true)]
    public partial class getCarriersRequest {
        
        public getCarriersRequest() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getCarriersResponse", WrapperNamespace="http://it.ilstu.edu/", IsWrapped=true)]
    public partial class getCarriersResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://it.ilstu.edu/", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("return", Form=System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable=true)]
        public string[] @return;
        
        public getCarriersResponse() {
        }
        
        public getCarriersResponse(string[] @return) {
            this.@return = @return;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TextSenderChannel : LinkedU.ServiceReference1.TextSender, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TextSenderClient : System.ServiceModel.ClientBase<LinkedU.ServiceReference1.TextSender>, LinkedU.ServiceReference1.TextSender {
        
        public TextSenderClient() {
        }
        
        public TextSenderClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TextSenderClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TextSenderClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TextSenderClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LinkedU.ServiceReference1.sendSMSResponse LinkedU.ServiceReference1.TextSender.sendSMS(LinkedU.ServiceReference1.sendSMSRequest request) {
            return base.Channel.sendSMS(request);
        }
        
        public int sendSMS(string carrier, string telephoneNum, string text) {
            LinkedU.ServiceReference1.sendSMSRequest inValue = new LinkedU.ServiceReference1.sendSMSRequest();
            inValue.carrier = carrier;
            inValue.telephoneNum = telephoneNum;
            inValue.text = text;
            LinkedU.ServiceReference1.sendSMSResponse retVal = ((LinkedU.ServiceReference1.TextSender)(this)).sendSMS(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LinkedU.ServiceReference1.sendSMSResponse> LinkedU.ServiceReference1.TextSender.sendSMSAsync(LinkedU.ServiceReference1.sendSMSRequest request) {
            return base.Channel.sendSMSAsync(request);
        }
        
        public System.Threading.Tasks.Task<LinkedU.ServiceReference1.sendSMSResponse> sendSMSAsync(string carrier, string telephoneNum, string text) {
            LinkedU.ServiceReference1.sendSMSRequest inValue = new LinkedU.ServiceReference1.sendSMSRequest();
            inValue.carrier = carrier;
            inValue.telephoneNum = telephoneNum;
            inValue.text = text;
            return ((LinkedU.ServiceReference1.TextSender)(this)).sendSMSAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LinkedU.ServiceReference1.getCarriersResponse LinkedU.ServiceReference1.TextSender.getCarriers(LinkedU.ServiceReference1.getCarriersRequest request) {
            return base.Channel.getCarriers(request);
        }
        
        public string[] getCarriers() {
            LinkedU.ServiceReference1.getCarriersRequest inValue = new LinkedU.ServiceReference1.getCarriersRequest();
            LinkedU.ServiceReference1.getCarriersResponse retVal = ((LinkedU.ServiceReference1.TextSender)(this)).getCarriers(inValue);
            return retVal.@return;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LinkedU.ServiceReference1.getCarriersResponse> LinkedU.ServiceReference1.TextSender.getCarriersAsync(LinkedU.ServiceReference1.getCarriersRequest request) {
            return base.Channel.getCarriersAsync(request);
        }
        
        public System.Threading.Tasks.Task<LinkedU.ServiceReference1.getCarriersResponse> getCarriersAsync() {
            LinkedU.ServiceReference1.getCarriersRequest inValue = new LinkedU.ServiceReference1.getCarriersRequest();
            return ((LinkedU.ServiceReference1.TextSender)(this)).getCarriersAsync(inValue);
        }
    }
}
