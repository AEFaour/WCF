﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfAppWebServiceMeteo.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MeteoData", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    public partial class MeteoData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double d_PrecJourField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double d_PresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double d_TempField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double d_TempPRField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double d_TempRField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double d_VentDirField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double d_VentVitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime dt_ReleveField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int i_HumField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string s_ReturnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string s_VentDirStrField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double d_PrecJour {
            get {
                return this.d_PrecJourField;
            }
            set {
                if ((this.d_PrecJourField.Equals(value) != true)) {
                    this.d_PrecJourField = value;
                    this.RaisePropertyChanged("d_PrecJour");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double d_Pres {
            get {
                return this.d_PresField;
            }
            set {
                if ((this.d_PresField.Equals(value) != true)) {
                    this.d_PresField = value;
                    this.RaisePropertyChanged("d_Pres");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double d_Temp {
            get {
                return this.d_TempField;
            }
            set {
                if ((this.d_TempField.Equals(value) != true)) {
                    this.d_TempField = value;
                    this.RaisePropertyChanged("d_Temp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double d_TempPR {
            get {
                return this.d_TempPRField;
            }
            set {
                if ((this.d_TempPRField.Equals(value) != true)) {
                    this.d_TempPRField = value;
                    this.RaisePropertyChanged("d_TempPR");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double d_TempR {
            get {
                return this.d_TempRField;
            }
            set {
                if ((this.d_TempRField.Equals(value) != true)) {
                    this.d_TempRField = value;
                    this.RaisePropertyChanged("d_TempR");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double d_VentDir {
            get {
                return this.d_VentDirField;
            }
            set {
                if ((this.d_VentDirField.Equals(value) != true)) {
                    this.d_VentDirField = value;
                    this.RaisePropertyChanged("d_VentDir");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double d_VentVit {
            get {
                return this.d_VentVitField;
            }
            set {
                if ((this.d_VentVitField.Equals(value) != true)) {
                    this.d_VentVitField = value;
                    this.RaisePropertyChanged("d_VentVit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime dt_Releve {
            get {
                return this.dt_ReleveField;
            }
            set {
                if ((this.dt_ReleveField.Equals(value) != true)) {
                    this.dt_ReleveField = value;
                    this.RaisePropertyChanged("dt_Releve");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int i_Hum {
            get {
                return this.i_HumField;
            }
            set {
                if ((this.i_HumField.Equals(value) != true)) {
                    this.i_HumField = value;
                    this.RaisePropertyChanged("i_Hum");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string s_Return {
            get {
                return this.s_ReturnField;
            }
            set {
                if ((object.ReferenceEquals(this.s_ReturnField, value) != true)) {
                    this.s_ReturnField = value;
                    this.RaisePropertyChanged("s_Return");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string s_VentDirStr {
            get {
                return this.s_VentDirStrField;
            }
            set {
                if ((object.ReferenceEquals(this.s_VentDirStrField, value) != true)) {
                    this.s_VentDirStrField = value;
                    this.RaisePropertyChanged("s_VentDirStr");
                }
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_Value", ReplyAction="http://tempuri.org/IService1/Get_ValueResponse")]
        WpfAppWebServiceMeteo.ServiceReference1.Get_ValueResponse Get_Value(WpfAppWebServiceMeteo.ServiceReference1.Get_ValueRequest request);
        
        // CODEGEN : Génération du contrat de message dans la mesure où l'opération compte plusieurs valeurs de retour.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_Value", ReplyAction="http://tempuri.org/IService1/Get_ValueResponse")]
        System.Threading.Tasks.Task<WpfAppWebServiceMeteo.ServiceReference1.Get_ValueResponse> Get_ValueAsync(WpfAppWebServiceMeteo.ServiceReference1.Get_ValueRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_MeteoData", ReplyAction="http://tempuri.org/IService1/Get_MeteoDataResponse")]
        WpfAppWebServiceMeteo.ServiceReference1.MeteoData Get_MeteoData();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_MeteoData", ReplyAction="http://tempuri.org/IService1/Get_MeteoDataResponse")]
        System.Threading.Tasks.Task<WpfAppWebServiceMeteo.ServiceReference1.MeteoData> Get_MeteoDataAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_MeteoDataByDateTime", ReplyAction="http://tempuri.org/IService1/Get_MeteoDataByDateTimeResponse")]
        WpfAppWebServiceMeteo.ServiceReference1.MeteoData Get_MeteoDataByDateTime(string s_DateValueIn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_MeteoDataByDateTime", ReplyAction="http://tempuri.org/IService1/Get_MeteoDataByDateTimeResponse")]
        System.Threading.Tasks.Task<WpfAppWebServiceMeteo.ServiceReference1.MeteoData> Get_MeteoDataByDateTimeAsync(string s_DateValueIn);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Get_Value", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Get_ValueRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int i_NumValue;
        
        public Get_ValueRequest() {
        }
        
        public Get_ValueRequest(int i_NumValue) {
            this.i_NumValue = i_NumValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Get_ValueResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class Get_ValueResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string Get_ValueResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string s_DateValue;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string s_DescValue;
        
        public Get_ValueResponse() {
        }
        
        public Get_ValueResponse(string Get_ValueResult, string s_DateValue, string s_DescValue) {
            this.Get_ValueResult = Get_ValueResult;
            this.s_DateValue = s_DateValue;
            this.s_DescValue = s_DescValue;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WpfAppWebServiceMeteo.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WpfAppWebServiceMeteo.ServiceReference1.IService1>, WpfAppWebServiceMeteo.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WpfAppWebServiceMeteo.ServiceReference1.Get_ValueResponse WpfAppWebServiceMeteo.ServiceReference1.IService1.Get_Value(WpfAppWebServiceMeteo.ServiceReference1.Get_ValueRequest request) {
            return base.Channel.Get_Value(request);
        }
        
        public string Get_Value(int i_NumValue, out string s_DateValue, out string s_DescValue) {
            WpfAppWebServiceMeteo.ServiceReference1.Get_ValueRequest inValue = new WpfAppWebServiceMeteo.ServiceReference1.Get_ValueRequest();
            inValue.i_NumValue = i_NumValue;
            WpfAppWebServiceMeteo.ServiceReference1.Get_ValueResponse retVal = ((WpfAppWebServiceMeteo.ServiceReference1.IService1)(this)).Get_Value(inValue);
            s_DateValue = retVal.s_DateValue;
            s_DescValue = retVal.s_DescValue;
            return retVal.Get_ValueResult;
        }
        
        public System.Threading.Tasks.Task<WpfAppWebServiceMeteo.ServiceReference1.Get_ValueResponse> Get_ValueAsync(WpfAppWebServiceMeteo.ServiceReference1.Get_ValueRequest request) {
            return base.Channel.Get_ValueAsync(request);
        }
        
        public WpfAppWebServiceMeteo.ServiceReference1.MeteoData Get_MeteoData() {
            return base.Channel.Get_MeteoData();
        }
        
        public System.Threading.Tasks.Task<WpfAppWebServiceMeteo.ServiceReference1.MeteoData> Get_MeteoDataAsync() {
            return base.Channel.Get_MeteoDataAsync();
        }
        
        public WpfAppWebServiceMeteo.ServiceReference1.MeteoData Get_MeteoDataByDateTime(string s_DateValueIn) {
            return base.Channel.Get_MeteoDataByDateTime(s_DateValueIn);
        }
        
        public System.Threading.Tasks.Task<WpfAppWebServiceMeteo.ServiceReference1.MeteoData> Get_MeteoDataByDateTimeAsync(string s_DateValueIn) {
            return base.Channel.Get_MeteoDataByDateTimeAsync(s_DateValueIn);
        }
    }
}