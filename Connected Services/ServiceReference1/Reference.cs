﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CdrFacturaPrueba.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://service.sunat.gob.pe", ConfigurationName="ServiceReference1.billService")]
    public interface billService {
        
        // CODEGEN: El parámetro 'statusCdr' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:getStatusCdr", ReplyAction="http://service.sunat.gob.pe/billService/getStatusCdrResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="statusCdr")]
        CdrFacturaPrueba.ServiceReference1.getStatusCdrResponse getStatusCdr(CdrFacturaPrueba.ServiceReference1.getStatusCdrRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:getStatusCdr", ReplyAction="http://service.sunat.gob.pe/billService/getStatusCdrResponse")]
        System.IAsyncResult BegingetStatusCdr(CdrFacturaPrueba.ServiceReference1.getStatusCdrRequest request, System.AsyncCallback callback, object asyncState);
        
        CdrFacturaPrueba.ServiceReference1.getStatusCdrResponse EndgetStatusCdr(System.IAsyncResult result);
        
        // CODEGEN: El parámetro 'status' requiere información adicional de esquema que no se puede capturar con el modo de parámetros. El atributo específico es 'System.Xml.Serialization.XmlElementAttribute'.
        [System.ServiceModel.OperationContractAttribute(Action="urn:getStatus", ReplyAction="http://service.sunat.gob.pe/billService/getStatusResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="status")]
        CdrFacturaPrueba.ServiceReference1.getStatusResponse getStatus(CdrFacturaPrueba.ServiceReference1.getStatusRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:getStatus", ReplyAction="http://service.sunat.gob.pe/billService/getStatusResponse")]
        System.IAsyncResult BegingetStatus(CdrFacturaPrueba.ServiceReference1.getStatusRequest request, System.AsyncCallback callback, object asyncState);
        
        CdrFacturaPrueba.ServiceReference1.getStatusResponse EndgetStatus(System.IAsyncResult result);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://service.sunat.gob.pe")]
    public partial class statusResponse : object, System.ComponentModel.INotifyPropertyChanged {
        
        private byte[] contentField;
        
        private string statusCodeField;
        
        private string statusMessageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType="base64Binary", Order=0)]
        public byte[] content {
            get {
                return this.contentField;
            }
            set {
                this.contentField = value;
                this.RaisePropertyChanged("content");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string statusCode {
            get {
                return this.statusCodeField;
            }
            set {
                this.statusCodeField = value;
                this.RaisePropertyChanged("statusCode");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string statusMessage {
            get {
                return this.statusMessageField;
            }
            set {
                this.statusMessageField = value;
                this.RaisePropertyChanged("statusMessage");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStatusCdr", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class getStatusCdrRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string rucComprobante;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tipoComprobante;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string serieComprobante;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int numeroComprobante;
        
        public getStatusCdrRequest() {
        }
        
        public getStatusCdrRequest(string rucComprobante, string tipoComprobante, string serieComprobante, int numeroComprobante) {
            this.rucComprobante = rucComprobante;
            this.tipoComprobante = tipoComprobante;
            this.serieComprobante = serieComprobante;
            this.numeroComprobante = numeroComprobante;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStatusCdrResponse", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class getStatusCdrResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CdrFacturaPrueba.ServiceReference1.statusResponse statusCdr;
        
        public getStatusCdrResponse() {
        }
        
        public getStatusCdrResponse(CdrFacturaPrueba.ServiceReference1.statusResponse statusCdr) {
            this.statusCdr = statusCdr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStatus", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class getStatusRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string rucComprobante;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string tipoComprobante;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public string serieComprobante;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public int numeroComprobante;
        
        public getStatusRequest() {
        }
        
        public getStatusRequest(string rucComprobante, string tipoComprobante, string serieComprobante, int numeroComprobante) {
            this.rucComprobante = rucComprobante;
            this.tipoComprobante = tipoComprobante;
            this.serieComprobante = serieComprobante;
            this.numeroComprobante = numeroComprobante;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="getStatusResponse", WrapperNamespace="http://service.sunat.gob.pe", IsWrapped=true)]
    public partial class getStatusResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://service.sunat.gob.pe", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public CdrFacturaPrueba.ServiceReference1.statusResponse status;
        
        public getStatusResponse() {
        }
        
        public getStatusResponse(CdrFacturaPrueba.ServiceReference1.statusResponse status) {
            this.status = status;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface billServiceChannel : CdrFacturaPrueba.ServiceReference1.billService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class getStatusCdrCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public getStatusCdrCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public CdrFacturaPrueba.ServiceReference1.statusResponse Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((CdrFacturaPrueba.ServiceReference1.statusResponse)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class getStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public getStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public CdrFacturaPrueba.ServiceReference1.statusResponse Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((CdrFacturaPrueba.ServiceReference1.statusResponse)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class billServiceClient : System.ServiceModel.ClientBase<CdrFacturaPrueba.ServiceReference1.billService>, CdrFacturaPrueba.ServiceReference1.billService {
        
        private BeginOperationDelegate onBegingetStatusCdrDelegate;
        
        private EndOperationDelegate onEndgetStatusCdrDelegate;
        
        private System.Threading.SendOrPostCallback ongetStatusCdrCompletedDelegate;
        
        private BeginOperationDelegate onBegingetStatusDelegate;
        
        private EndOperationDelegate onEndgetStatusDelegate;
        
        private System.Threading.SendOrPostCallback ongetStatusCompletedDelegate;
        
        public billServiceClient() {
        }
        
        public billServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public billServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public billServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public billServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<getStatusCdrCompletedEventArgs> getStatusCdrCompleted;
        
        public event System.EventHandler<getStatusCompletedEventArgs> getStatusCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CdrFacturaPrueba.ServiceReference1.getStatusCdrResponse CdrFacturaPrueba.ServiceReference1.billService.getStatusCdr(CdrFacturaPrueba.ServiceReference1.getStatusCdrRequest request) {
            return base.Channel.getStatusCdr(request);
        }
        
        public CdrFacturaPrueba.ServiceReference1.statusResponse getStatusCdr(string rucComprobante, string tipoComprobante, string serieComprobante, int numeroComprobante) {
            CdrFacturaPrueba.ServiceReference1.getStatusCdrRequest inValue = new CdrFacturaPrueba.ServiceReference1.getStatusCdrRequest();
            inValue.rucComprobante = rucComprobante;
            inValue.tipoComprobante = tipoComprobante;
            inValue.serieComprobante = serieComprobante;
            inValue.numeroComprobante = numeroComprobante;
            CdrFacturaPrueba.ServiceReference1.getStatusCdrResponse retVal = ((CdrFacturaPrueba.ServiceReference1.billService)(this)).getStatusCdr(inValue);
            return retVal.statusCdr;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult CdrFacturaPrueba.ServiceReference1.billService.BegingetStatusCdr(CdrFacturaPrueba.ServiceReference1.getStatusCdrRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BegingetStatusCdr(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BegingetStatusCdr(string rucComprobante, string tipoComprobante, string serieComprobante, int numeroComprobante, System.AsyncCallback callback, object asyncState) {
            CdrFacturaPrueba.ServiceReference1.getStatusCdrRequest inValue = new CdrFacturaPrueba.ServiceReference1.getStatusCdrRequest();
            inValue.rucComprobante = rucComprobante;
            inValue.tipoComprobante = tipoComprobante;
            inValue.serieComprobante = serieComprobante;
            inValue.numeroComprobante = numeroComprobante;
            return ((CdrFacturaPrueba.ServiceReference1.billService)(this)).BegingetStatusCdr(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CdrFacturaPrueba.ServiceReference1.getStatusCdrResponse CdrFacturaPrueba.ServiceReference1.billService.EndgetStatusCdr(System.IAsyncResult result) {
            return base.Channel.EndgetStatusCdr(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public CdrFacturaPrueba.ServiceReference1.statusResponse EndgetStatusCdr(System.IAsyncResult result) {
            CdrFacturaPrueba.ServiceReference1.getStatusCdrResponse retVal = ((CdrFacturaPrueba.ServiceReference1.billService)(this)).EndgetStatusCdr(result);
            return retVal.statusCdr;
        }
        
        private System.IAsyncResult OnBegingetStatusCdr(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string rucComprobante = ((string)(inValues[0]));
            string tipoComprobante = ((string)(inValues[1]));
            string serieComprobante = ((string)(inValues[2]));
            int numeroComprobante = ((int)(inValues[3]));
            return this.BegingetStatusCdr(rucComprobante, tipoComprobante, serieComprobante, numeroComprobante, callback, asyncState);
        }
        
        private object[] OnEndgetStatusCdr(System.IAsyncResult result) {
            CdrFacturaPrueba.ServiceReference1.statusResponse retVal = this.EndgetStatusCdr(result);
            return new object[] {
                    retVal};
        }
        
        private void OngetStatusCdrCompleted(object state) {
            if ((this.getStatusCdrCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.getStatusCdrCompleted(this, new getStatusCdrCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void getStatusCdrAsync(string rucComprobante, string tipoComprobante, string serieComprobante, int numeroComprobante) {
            this.getStatusCdrAsync(rucComprobante, tipoComprobante, serieComprobante, numeroComprobante, null);
        }
        
        public void getStatusCdrAsync(string rucComprobante, string tipoComprobante, string serieComprobante, int numeroComprobante, object userState) {
            if ((this.onBegingetStatusCdrDelegate == null)) {
                this.onBegingetStatusCdrDelegate = new BeginOperationDelegate(this.OnBegingetStatusCdr);
            }
            if ((this.onEndgetStatusCdrDelegate == null)) {
                this.onEndgetStatusCdrDelegate = new EndOperationDelegate(this.OnEndgetStatusCdr);
            }
            if ((this.ongetStatusCdrCompletedDelegate == null)) {
                this.ongetStatusCdrCompletedDelegate = new System.Threading.SendOrPostCallback(this.OngetStatusCdrCompleted);
            }
            base.InvokeAsync(this.onBegingetStatusCdrDelegate, new object[] {
                        rucComprobante,
                        tipoComprobante,
                        serieComprobante,
                        numeroComprobante}, this.onEndgetStatusCdrDelegate, this.ongetStatusCdrCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CdrFacturaPrueba.ServiceReference1.getStatusResponse CdrFacturaPrueba.ServiceReference1.billService.getStatus(CdrFacturaPrueba.ServiceReference1.getStatusRequest request) {
            return base.Channel.getStatus(request);
        }
        
        public CdrFacturaPrueba.ServiceReference1.statusResponse getStatus(string rucComprobante, string tipoComprobante, string serieComprobante, int numeroComprobante) {
            CdrFacturaPrueba.ServiceReference1.getStatusRequest inValue = new CdrFacturaPrueba.ServiceReference1.getStatusRequest();
            inValue.rucComprobante = rucComprobante;
            inValue.tipoComprobante = tipoComprobante;
            inValue.serieComprobante = serieComprobante;
            inValue.numeroComprobante = numeroComprobante;
            CdrFacturaPrueba.ServiceReference1.getStatusResponse retVal = ((CdrFacturaPrueba.ServiceReference1.billService)(this)).getStatus(inValue);
            return retVal.status;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult CdrFacturaPrueba.ServiceReference1.billService.BegingetStatus(CdrFacturaPrueba.ServiceReference1.getStatusRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BegingetStatus(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BegingetStatus(string rucComprobante, string tipoComprobante, string serieComprobante, int numeroComprobante, System.AsyncCallback callback, object asyncState) {
            CdrFacturaPrueba.ServiceReference1.getStatusRequest inValue = new CdrFacturaPrueba.ServiceReference1.getStatusRequest();
            inValue.rucComprobante = rucComprobante;
            inValue.tipoComprobante = tipoComprobante;
            inValue.serieComprobante = serieComprobante;
            inValue.numeroComprobante = numeroComprobante;
            return ((CdrFacturaPrueba.ServiceReference1.billService)(this)).BegingetStatus(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CdrFacturaPrueba.ServiceReference1.getStatusResponse CdrFacturaPrueba.ServiceReference1.billService.EndgetStatus(System.IAsyncResult result) {
            return base.Channel.EndgetStatus(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public CdrFacturaPrueba.ServiceReference1.statusResponse EndgetStatus(System.IAsyncResult result) {
            CdrFacturaPrueba.ServiceReference1.getStatusResponse retVal = ((CdrFacturaPrueba.ServiceReference1.billService)(this)).EndgetStatus(result);
            return retVal.status;
        }
        
        private System.IAsyncResult OnBegingetStatus(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string rucComprobante = ((string)(inValues[0]));
            string tipoComprobante = ((string)(inValues[1]));
            string serieComprobante = ((string)(inValues[2]));
            int numeroComprobante = ((int)(inValues[3]));
            return this.BegingetStatus(rucComprobante, tipoComprobante, serieComprobante, numeroComprobante, callback, asyncState);
        }
        
        private object[] OnEndgetStatus(System.IAsyncResult result) {
            CdrFacturaPrueba.ServiceReference1.statusResponse retVal = this.EndgetStatus(result);
            return new object[] {
                    retVal};
        }
        
        private void OngetStatusCompleted(object state) {
            if ((this.getStatusCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.getStatusCompleted(this, new getStatusCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void getStatusAsync(string rucComprobante, string tipoComprobante, string serieComprobante, int numeroComprobante) {
            this.getStatusAsync(rucComprobante, tipoComprobante, serieComprobante, numeroComprobante, null);
        }
        
        public void getStatusAsync(string rucComprobante, string tipoComprobante, string serieComprobante, int numeroComprobante, object userState) {
            if ((this.onBegingetStatusDelegate == null)) {
                this.onBegingetStatusDelegate = new BeginOperationDelegate(this.OnBegingetStatus);
            }
            if ((this.onEndgetStatusDelegate == null)) {
                this.onEndgetStatusDelegate = new EndOperationDelegate(this.OnEndgetStatus);
            }
            if ((this.ongetStatusCompletedDelegate == null)) {
                this.ongetStatusCompletedDelegate = new System.Threading.SendOrPostCallback(this.OngetStatusCompleted);
            }
            base.InvokeAsync(this.onBegingetStatusDelegate, new object[] {
                        rucComprobante,
                        tipoComprobante,
                        serieComprobante,
                        numeroComprobante}, this.onEndgetStatusDelegate, this.ongetStatusCompletedDelegate, userState);
        }
    }
}
