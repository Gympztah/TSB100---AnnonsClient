﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnnonsTjanst.LoginService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Anvandare", Namespace="http://schemas.datacontract.org/2004/07/Inloggning")]
    [System.SerializableAttribute()]
    public partial class Anvandare : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AnvandarnamnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BehorighetField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LosenordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> ProfilIdField;
        
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
        public string Anvandarnamn {
            get {
                return this.AnvandarnamnField;
            }
            set {
                if ((object.ReferenceEquals(this.AnvandarnamnField, value) != true)) {
                    this.AnvandarnamnField = value;
                    this.RaisePropertyChanged("Anvandarnamn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Behorighet {
            get {
                return this.BehorighetField;
            }
            set {
                if ((object.ReferenceEquals(this.BehorighetField, value) != true)) {
                    this.BehorighetField = value;
                    this.RaisePropertyChanged("Behorighet");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Losenord {
            get {
                return this.LosenordField;
            }
            set {
                if ((object.ReferenceEquals(this.LosenordField, value) != true)) {
                    this.LosenordField = value;
                    this.RaisePropertyChanged("Losenord");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> ProfilId {
            get {
                return this.ProfilIdField;
            }
            set {
                if ((this.ProfilIdField.Equals(value) != true)) {
                    this.ProfilIdField = value;
                    this.RaisePropertyChanged("ProfilId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LoginService.IInloggningService")]
    public interface IInloggningService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInloggningService/TestaAnslutning", ReplyAction="http://tempuri.org/IInloggningService/TestaAnslutningResponse")]
        string TestaAnslutning();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInloggningService/TestaAnslutning", ReplyAction="http://tempuri.org/IInloggningService/TestaAnslutningResponse")]
        System.Threading.Tasks.Task<string> TestaAnslutningAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInloggningService/LoggaIn", ReplyAction="http://tempuri.org/IInloggningService/LoggaInResponse")]
        AnnonsTjanst.LoginService.Anvandare LoggaIn(string anvandarNamn, string losenord, string behorighet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInloggningService/LoggaIn", ReplyAction="http://tempuri.org/IInloggningService/LoggaInResponse")]
        System.Threading.Tasks.Task<AnnonsTjanst.LoginService.Anvandare> LoggaInAsync(string anvandarNamn, string losenord, string behorighet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInloggningService/SkapaSession", ReplyAction="http://tempuri.org/IInloggningService/SkapaSessionResponse")]
        bool SkapaSession(int profilId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInloggningService/SkapaSession", ReplyAction="http://tempuri.org/IInloggningService/SkapaSessionResponse")]
        System.Threading.Tasks.Task<bool> SkapaSessionAsync(int profilId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInloggningService/LoggaUt", ReplyAction="http://tempuri.org/IInloggningService/LoggaUtResponse")]
        bool LoggaUt(int anvandarId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInloggningService/LoggaUt", ReplyAction="http://tempuri.org/IInloggningService/LoggaUtResponse")]
        System.Threading.Tasks.Task<bool> LoggaUtAsync(int anvandarId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInloggningService/RegistreraAnvandare", ReplyAction="http://tempuri.org/IInloggningService/RegistreraAnvandareResponse")]
        bool RegistreraAnvandare(string anvandarNamn, string losenord, string email, int profilID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInloggningService/RegistreraAnvandare", ReplyAction="http://tempuri.org/IInloggningService/RegistreraAnvandareResponse")]
        System.Threading.Tasks.Task<bool> RegistreraAnvandareAsync(string anvandarNamn, string losenord, string email, int profilID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInloggningService/VisaAnvandarInfo", ReplyAction="http://tempuri.org/IInloggningService/VisaAnvandarInfoResponse")]
        AnnonsTjanst.LoginService.Anvandare VisaAnvandarInfo(string anvandarNamn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInloggningService/VisaAnvandarInfo", ReplyAction="http://tempuri.org/IInloggningService/VisaAnvandarInfoResponse")]
        System.Threading.Tasks.Task<AnnonsTjanst.LoginService.Anvandare> VisaAnvandarInfoAsync(string anvandarNamn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInloggningService/VisaAnvandarInfoId", ReplyAction="http://tempuri.org/IInloggningService/VisaAnvandarInfoIdResponse")]
        AnnonsTjanst.LoginService.Anvandare VisaAnvandarInfoId(int profilId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInloggningService/VisaAnvandarInfoId", ReplyAction="http://tempuri.org/IInloggningService/VisaAnvandarInfoIdResponse")]
        System.Threading.Tasks.Task<AnnonsTjanst.LoginService.Anvandare> VisaAnvandarInfoIdAsync(int profilId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInloggningService/AndraLosenord", ReplyAction="http://tempuri.org/IInloggningService/AndraLosenordResponse")]
        bool AndraLosenord(int anvandarId, string losenordGammal, string losenordNytt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInloggningService/AndraLosenord", ReplyAction="http://tempuri.org/IInloggningService/AndraLosenordResponse")]
        System.Threading.Tasks.Task<bool> AndraLosenordAsync(int anvandarId, string losenordGammal, string losenordNytt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInloggningService/HamtaAllaAnvandare", ReplyAction="http://tempuri.org/IInloggningService/HamtaAllaAnvandareResponse")]
        AnnonsTjanst.LoginService.Anvandare[] HamtaAllaAnvandare();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInloggningService/HamtaAllaAnvandare", ReplyAction="http://tempuri.org/IInloggningService/HamtaAllaAnvandareResponse")]
        System.Threading.Tasks.Task<AnnonsTjanst.LoginService.Anvandare[]> HamtaAllaAnvandareAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInloggningService/RegistreraAdmin", ReplyAction="http://tempuri.org/IInloggningService/RegistreraAdminResponse")]
        bool RegistreraAdmin(string anvandarNamn, string losenord, string email, string behorighet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInloggningService/RegistreraAdmin", ReplyAction="http://tempuri.org/IInloggningService/RegistreraAdminResponse")]
        System.Threading.Tasks.Task<bool> RegistreraAdminAsync(string anvandarNamn, string losenord, string email, string behorighet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInloggningService/AndraBehorighet", ReplyAction="http://tempuri.org/IInloggningService/AndraBehorighetResponse")]
        bool AndraBehorighet(int anvandarId, string behorighet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInloggningService/AndraBehorighet", ReplyAction="http://tempuri.org/IInloggningService/AndraBehorighetResponse")]
        System.Threading.Tasks.Task<bool> AndraBehorighetAsync(int anvandarId, string behorighet);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInloggningService/VerifieraInloggning", ReplyAction="http://tempuri.org/IInloggningService/VerifieraInloggningResponse")]
        bool VerifieraInloggning(int profilId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInloggningService/VerifieraInloggning", ReplyAction="http://tempuri.org/IInloggningService/VerifieraInloggningResponse")]
        System.Threading.Tasks.Task<bool> VerifieraInloggningAsync(int profilId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInloggningService/TaBortAnvandare", ReplyAction="http://tempuri.org/IInloggningService/TaBortAnvandareResponse")]
        bool TaBortAnvandare(int anvandarId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IInloggningService/TaBortAnvandare", ReplyAction="http://tempuri.org/IInloggningService/TaBortAnvandareResponse")]
        System.Threading.Tasks.Task<bool> TaBortAnvandareAsync(int anvandarId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IInloggningServiceChannel : AnnonsTjanst.LoginService.IInloggningService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InloggningServiceClient : System.ServiceModel.ClientBase<AnnonsTjanst.LoginService.IInloggningService>, AnnonsTjanst.LoginService.IInloggningService {
        
        public InloggningServiceClient() {
        }
        
        public InloggningServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InloggningServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InloggningServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InloggningServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string TestaAnslutning() {
            return base.Channel.TestaAnslutning();
        }
        
        public System.Threading.Tasks.Task<string> TestaAnslutningAsync() {
            return base.Channel.TestaAnslutningAsync();
        }
        
        public AnnonsTjanst.LoginService.Anvandare LoggaIn(string anvandarNamn, string losenord, string behorighet) {
            return base.Channel.LoggaIn(anvandarNamn, losenord, behorighet);
        }
        
        public System.Threading.Tasks.Task<AnnonsTjanst.LoginService.Anvandare> LoggaInAsync(string anvandarNamn, string losenord, string behorighet) {
            return base.Channel.LoggaInAsync(anvandarNamn, losenord, behorighet);
        }
        
        public bool SkapaSession(int profilId) {
            return base.Channel.SkapaSession(profilId);
        }
        
        public System.Threading.Tasks.Task<bool> SkapaSessionAsync(int profilId) {
            return base.Channel.SkapaSessionAsync(profilId);
        }
        
        public bool LoggaUt(int anvandarId) {
            return base.Channel.LoggaUt(anvandarId);
        }
        
        public System.Threading.Tasks.Task<bool> LoggaUtAsync(int anvandarId) {
            return base.Channel.LoggaUtAsync(anvandarId);
        }
        
        public bool RegistreraAnvandare(string anvandarNamn, string losenord, string email, int profilID) {
            return base.Channel.RegistreraAnvandare(anvandarNamn, losenord, email, profilID);
        }
        
        public System.Threading.Tasks.Task<bool> RegistreraAnvandareAsync(string anvandarNamn, string losenord, string email, int profilID) {
            return base.Channel.RegistreraAnvandareAsync(anvandarNamn, losenord, email, profilID);
        }
        
        public AnnonsTjanst.LoginService.Anvandare VisaAnvandarInfo(string anvandarNamn) {
            return base.Channel.VisaAnvandarInfo(anvandarNamn);
        }
        
        public System.Threading.Tasks.Task<AnnonsTjanst.LoginService.Anvandare> VisaAnvandarInfoAsync(string anvandarNamn) {
            return base.Channel.VisaAnvandarInfoAsync(anvandarNamn);
        }
        
        public AnnonsTjanst.LoginService.Anvandare VisaAnvandarInfoId(int profilId) {
            return base.Channel.VisaAnvandarInfoId(profilId);
        }
        
        public System.Threading.Tasks.Task<AnnonsTjanst.LoginService.Anvandare> VisaAnvandarInfoIdAsync(int profilId) {
            return base.Channel.VisaAnvandarInfoIdAsync(profilId);
        }
        
        public bool AndraLosenord(int anvandarId, string losenordGammal, string losenordNytt) {
            return base.Channel.AndraLosenord(anvandarId, losenordGammal, losenordNytt);
        }
        
        public System.Threading.Tasks.Task<bool> AndraLosenordAsync(int anvandarId, string losenordGammal, string losenordNytt) {
            return base.Channel.AndraLosenordAsync(anvandarId, losenordGammal, losenordNytt);
        }
        
        public AnnonsTjanst.LoginService.Anvandare[] HamtaAllaAnvandare() {
            return base.Channel.HamtaAllaAnvandare();
        }
        
        public System.Threading.Tasks.Task<AnnonsTjanst.LoginService.Anvandare[]> HamtaAllaAnvandareAsync() {
            return base.Channel.HamtaAllaAnvandareAsync();
        }
        
        public bool RegistreraAdmin(string anvandarNamn, string losenord, string email, string behorighet) {
            return base.Channel.RegistreraAdmin(anvandarNamn, losenord, email, behorighet);
        }
        
        public System.Threading.Tasks.Task<bool> RegistreraAdminAsync(string anvandarNamn, string losenord, string email, string behorighet) {
            return base.Channel.RegistreraAdminAsync(anvandarNamn, losenord, email, behorighet);
        }
        
        public bool AndraBehorighet(int anvandarId, string behorighet) {
            return base.Channel.AndraBehorighet(anvandarId, behorighet);
        }
        
        public System.Threading.Tasks.Task<bool> AndraBehorighetAsync(int anvandarId, string behorighet) {
            return base.Channel.AndraBehorighetAsync(anvandarId, behorighet);
        }
        
        public bool VerifieraInloggning(int profilId) {
            return base.Channel.VerifieraInloggning(profilId);
        }
        
        public System.Threading.Tasks.Task<bool> VerifieraInloggningAsync(int profilId) {
            return base.Channel.VerifieraInloggningAsync(profilId);
        }
        
        public bool TaBortAnvandare(int anvandarId) {
            return base.Channel.TaBortAnvandare(anvandarId);
        }
        
        public System.Threading.Tasks.Task<bool> TaBortAnvandareAsync(int anvandarId) {
            return base.Channel.TaBortAnvandareAsync(anvandarId);
        }
    }
}
