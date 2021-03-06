﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleAppClientAbonne.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Abonne", Namespace="http://schemas.datacontract.org/2004/07/WcfWServiceAbonnes.Model")]
    [System.SerializableAttribute()]
    public partial class Abonne : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumeroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrenomField;
        
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
        public string Mail {
            get {
                return this.MailField;
            }
            set {
                if ((object.ReferenceEquals(this.MailField, value) != true)) {
                    this.MailField = value;
                    this.RaisePropertyChanged("Mail");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nom {
            get {
                return this.NomField;
            }
            set {
                if ((object.ReferenceEquals(this.NomField, value) != true)) {
                    this.NomField = value;
                    this.RaisePropertyChanged("Nom");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Numero {
            get {
                return this.NumeroField;
            }
            set {
                if ((this.NumeroField.Equals(value) != true)) {
                    this.NumeroField = value;
                    this.RaisePropertyChanged("Numero");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Prenom {
            get {
                return this.PrenomField;
            }
            set {
                if ((object.ReferenceEquals(this.PrenomField, value) != true)) {
                    this.PrenomField = value;
                    this.RaisePropertyChanged("Prenom");
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
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AjoutAbonne", ReplyAction="http://tempuri.org/IService1/AjoutAbonneResponse")]
        int AjoutAbonne(ConsoleAppClientAbonne.ServiceReference1.Abonne abonne);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AjoutAbonne", ReplyAction="http://tempuri.org/IService1/AjoutAbonneResponse")]
        System.Threading.Tasks.Task<int> AjoutAbonneAsync(ConsoleAppClientAbonne.ServiceReference1.Abonne abonne);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SuppAbonneById", ReplyAction="http://tempuri.org/IService1/SuppAbonneByIdResponse")]
        bool SuppAbonneById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SuppAbonneById", ReplyAction="http://tempuri.org/IService1/SuppAbonneByIdResponse")]
        System.Threading.Tasks.Task<bool> SuppAbonneByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ModifAbonne", ReplyAction="http://tempuri.org/IService1/ModifAbonneResponse")]
        bool ModifAbonne(ConsoleAppClientAbonne.ServiceReference1.Abonne abonne);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ModifAbonne", ReplyAction="http://tempuri.org/IService1/ModifAbonneResponse")]
        System.Threading.Tasks.Task<bool> ModifAbonneAsync(ConsoleAppClientAbonne.ServiceReference1.Abonne abonne);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListAbonnes", ReplyAction="http://tempuri.org/IService1/ListAbonnesResponse")]
        ConsoleAppClientAbonne.ServiceReference1.Abonne[] ListAbonnes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/ListAbonnes", ReplyAction="http://tempuri.org/IService1/ListAbonnesResponse")]
        System.Threading.Tasks.Task<ConsoleAppClientAbonne.ServiceReference1.Abonne[]> ListAbonnesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RechercheParCritere", ReplyAction="http://tempuri.org/IService1/RechercheParCritereResponse")]
        ConsoleAppClientAbonne.ServiceReference1.Abonne[] RechercheParCritere(string critere);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RechercheParCritere", ReplyAction="http://tempuri.org/IService1/RechercheParCritereResponse")]
        System.Threading.Tasks.Task<ConsoleAppClientAbonne.ServiceReference1.Abonne[]> RechercheParCritereAsync(string critere);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ConsoleAppClientAbonne.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ConsoleAppClientAbonne.ServiceReference1.IService1>, ConsoleAppClientAbonne.ServiceReference1.IService1 {
        
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
        
        public int AjoutAbonne(ConsoleAppClientAbonne.ServiceReference1.Abonne abonne) {
            return base.Channel.AjoutAbonne(abonne);
        }
        
        public System.Threading.Tasks.Task<int> AjoutAbonneAsync(ConsoleAppClientAbonne.ServiceReference1.Abonne abonne) {
            return base.Channel.AjoutAbonneAsync(abonne);
        }
        
        public bool SuppAbonneById(int id) {
            return base.Channel.SuppAbonneById(id);
        }
        
        public System.Threading.Tasks.Task<bool> SuppAbonneByIdAsync(int id) {
            return base.Channel.SuppAbonneByIdAsync(id);
        }
        
        public bool ModifAbonne(ConsoleAppClientAbonne.ServiceReference1.Abonne abonne) {
            return base.Channel.ModifAbonne(abonne);
        }
        
        public System.Threading.Tasks.Task<bool> ModifAbonneAsync(ConsoleAppClientAbonne.ServiceReference1.Abonne abonne) {
            return base.Channel.ModifAbonneAsync(abonne);
        }
        
        public ConsoleAppClientAbonne.ServiceReference1.Abonne[] ListAbonnes() {
            return base.Channel.ListAbonnes();
        }
        
        public System.Threading.Tasks.Task<ConsoleAppClientAbonne.ServiceReference1.Abonne[]> ListAbonnesAsync() {
            return base.Channel.ListAbonnesAsync();
        }
        
        public ConsoleAppClientAbonne.ServiceReference1.Abonne[] RechercheParCritere(string critere) {
            return base.Channel.RechercheParCritere(critere);
        }
        
        public System.Threading.Tasks.Task<ConsoleAppClientAbonne.ServiceReference1.Abonne[]> RechercheParCritereAsync(string critere) {
            return base.Channel.RechercheParCritereAsync(critere);
        }
    }
}
