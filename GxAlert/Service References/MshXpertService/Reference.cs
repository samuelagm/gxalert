﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GxAlert.MshXpertService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://etbmanager.org/xpertservice", ConfigurationName="MshXpertService.xpertService")]
    public interface xpertService {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(Style=System.ServiceModel.OperationFormatStyle.Rpc, SupportFaults=true)]
        [return: System.ServiceModel.MessageParameterAttribute(Name="return")]
        GxAlert.MshXpertService.response postResult(string sessionId, GxAlert.MshXpertService.xpertData examResult);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://etbmanager.org/xpertservice")]
    public partial class xpertData : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int caseIdField;
        
        private bool caseIdFieldSpecified;
        
        private string commentsField;
        
        private int laboratoryIdField;
        
        private bool laboratoryIdFieldSpecified;
        
        private System.DateTime releaseDateField;
        
        private bool releaseDateFieldSpecified;
        
        private xpertResult resultField;
        
        private bool resultFieldSpecified;
        
        private xpertRifResult rifResultField;
        
        private bool rifResultFieldSpecified;
        
        private System.DateTime sampleDateCollectedField;
        
        private bool sampleDateCollectedFieldSpecified;
        
        private string sampleIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public int caseId {
            get {
                return this.caseIdField;
            }
            set {
                this.caseIdField = value;
                this.RaisePropertyChanged("caseId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool caseIdSpecified {
            get {
                return this.caseIdFieldSpecified;
            }
            set {
                this.caseIdFieldSpecified = value;
                this.RaisePropertyChanged("caseIdSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public string comments {
            get {
                return this.commentsField;
            }
            set {
                this.commentsField = value;
                this.RaisePropertyChanged("comments");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public int laboratoryId {
            get {
                return this.laboratoryIdField;
            }
            set {
                this.laboratoryIdField = value;
                this.RaisePropertyChanged("laboratoryId");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool laboratoryIdSpecified {
            get {
                return this.laboratoryIdFieldSpecified;
            }
            set {
                this.laboratoryIdFieldSpecified = value;
                this.RaisePropertyChanged("laboratoryIdSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=3)]
        public System.DateTime releaseDate {
            get {
                return this.releaseDateField;
            }
            set {
                this.releaseDateField = value;
                this.RaisePropertyChanged("releaseDate");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool releaseDateSpecified {
            get {
                return this.releaseDateFieldSpecified;
            }
            set {
                this.releaseDateFieldSpecified = value;
                this.RaisePropertyChanged("releaseDateSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=4)]
        public xpertResult result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
                this.RaisePropertyChanged("result");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool resultSpecified {
            get {
                return this.resultFieldSpecified;
            }
            set {
                this.resultFieldSpecified = value;
                this.RaisePropertyChanged("resultSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=5)]
        public xpertRifResult rifResult {
            get {
                return this.rifResultField;
            }
            set {
                this.rifResultField = value;
                this.RaisePropertyChanged("rifResult");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rifResultSpecified {
            get {
                return this.rifResultFieldSpecified;
            }
            set {
                this.rifResultFieldSpecified = value;
                this.RaisePropertyChanged("rifResultSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=6)]
        public System.DateTime sampleDateCollected {
            get {
                return this.sampleDateCollectedField;
            }
            set {
                this.sampleDateCollectedField = value;
                this.RaisePropertyChanged("sampleDateCollected");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sampleDateCollectedSpecified {
            get {
                return this.sampleDateCollectedFieldSpecified;
            }
            set {
                this.sampleDateCollectedFieldSpecified = value;
                this.RaisePropertyChanged("sampleDateCollectedSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=7)]
        public string sampleId {
            get {
                return this.sampleIdField;
            }
            set {
                this.sampleIdField = value;
                this.RaisePropertyChanged("sampleId");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://etbmanager.org/xpertservice")]
    public enum xpertResult {
        
        /// <remarks/>
        INVALID,
        
        /// <remarks/>
        ERROR,
        
        /// <remarks/>
        NO_RESULT,
        
        /// <remarks/>
        ONGOING,
        
        /// <remarks/>
        TB_NOT_DETECTED,
        
        /// <remarks/>
        TB_DETECTED,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://etbmanager.org/xpertservice")]
    public enum xpertRifResult {
        
        /// <remarks/>
        RIF_DETECTED,
        
        /// <remarks/>
        RIF_NOT_DETECTED,
        
        /// <remarks/>
        RIF_INDETERMINATE,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18033")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://etbmanager.org/xpertservice")]
    public partial class response : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string errormsgField;
        
        private int errornoField;
        
        private string resultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=0)]
        public string errormsg {
            get {
                return this.errormsgField;
            }
            set {
                this.errormsgField = value;
                this.RaisePropertyChanged("errormsg");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=1)]
        public int errorno {
            get {
                return this.errornoField;
            }
            set {
                this.errornoField = value;
                this.RaisePropertyChanged("errorno");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Form=System.Xml.Schema.XmlSchemaForm.Unqualified, Order=2)]
        public string result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
                this.RaisePropertyChanged("result");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface xpertServiceChannel : GxAlert.MshXpertService.xpertService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class xpertServiceClient : System.ServiceModel.ClientBase<GxAlert.MshXpertService.xpertService>, GxAlert.MshXpertService.xpertService {
        
        public xpertServiceClient() {
        }
        
        public xpertServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public xpertServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public xpertServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public xpertServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GxAlert.MshXpertService.response postResult(string sessionId, GxAlert.MshXpertService.xpertData examResult) {
            return base.Channel.postResult(sessionId, examResult);
        }
    }
}