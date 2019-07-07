﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PresentationLayer.CardService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CardDTO", Namespace="http://schemas.datacontract.org/2004/07/BusinessLogicLayer.DTO")]
    [System.SerializableAttribute()]
    public partial class CardDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PresentationLayer.CardService.Color ColorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreationTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public PresentationLayer.CardService.Color Color {
            get {
                return this.ColorField;
            }
            set {
                if ((this.ColorField.Equals(value) != true)) {
                    this.ColorField = value;
                    this.RaisePropertyChanged("Color");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreationTime {
            get {
                return this.CreationTimeField;
            }
            set {
                if ((this.CreationTimeField.Equals(value) != true)) {
                    this.CreationTimeField = value;
                    this.RaisePropertyChanged("CreationTime");
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Color", Namespace="http://schemas.datacontract.org/2004/07/System.Drawing")]
    [System.SerializableAttribute()]
    public partial struct Color : System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private short knownColorField;
        
        private string nameField;
        
        private short stateField;
        
        private long valueField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public short knownColor {
            get {
                return this.knownColorField;
            }
            set {
                if ((this.knownColorField.Equals(value) != true)) {
                    this.knownColorField = value;
                    this.RaisePropertyChanged("knownColor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public short state {
            get {
                return this.stateField;
            }
            set {
                if ((this.stateField.Equals(value) != true)) {
                    this.stateField = value;
                    this.RaisePropertyChanged("state");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public long value {
            get {
                return this.valueField;
            }
            set {
                if ((this.valueField.Equals(value) != true)) {
                    this.valueField = value;
                    this.RaisePropertyChanged("value");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CardService.ICardMgmtContract")]
    public interface ICardMgmtContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICardMgmtContract/AddCard", ReplyAction="http://tempuri.org/ICardMgmtContract/AddCardResponse")]
        void AddCard(PresentationLayer.CardService.CardDTO card);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICardMgmtContract/AddCard", ReplyAction="http://tempuri.org/ICardMgmtContract/AddCardResponse")]
        System.Threading.Tasks.Task AddCardAsync(PresentationLayer.CardService.CardDTO card);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICardMgmtContract/FindCardById", ReplyAction="http://tempuri.org/ICardMgmtContract/FindCardByIdResponse")]
        PresentationLayer.CardService.CardDTO FindCardById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICardMgmtContract/FindCardById", ReplyAction="http://tempuri.org/ICardMgmtContract/FindCardByIdResponse")]
        System.Threading.Tasks.Task<PresentationLayer.CardService.CardDTO> FindCardByIdAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICardMgmtContract/GetAllCards", ReplyAction="http://tempuri.org/ICardMgmtContract/GetAllCardsResponse")]
        PresentationLayer.CardService.CardDTO[] GetAllCards();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICardMgmtContract/GetAllCards", ReplyAction="http://tempuri.org/ICardMgmtContract/GetAllCardsResponse")]
        System.Threading.Tasks.Task<PresentationLayer.CardService.CardDTO[]> GetAllCardsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICardMgmtContract/GetCards", ReplyAction="http://tempuri.org/ICardMgmtContract/GetCardsResponse")]
        PresentationLayer.CardService.CardDTO[] GetCards(System.Func<PresentationLayer.CardService.CardDTO, bool> predicate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICardMgmtContract/GetCards", ReplyAction="http://tempuri.org/ICardMgmtContract/GetCardsResponse")]
        System.Threading.Tasks.Task<PresentationLayer.CardService.CardDTO[]> GetCardsAsync(System.Func<PresentationLayer.CardService.CardDTO, bool> predicate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICardMgmtContract/RemoveCard", ReplyAction="http://tempuri.org/ICardMgmtContract/RemoveCardResponse")]
        void RemoveCard(PresentationLayer.CardService.CardDTO card);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICardMgmtContract/RemoveCard", ReplyAction="http://tempuri.org/ICardMgmtContract/RemoveCardResponse")]
        System.Threading.Tasks.Task RemoveCardAsync(PresentationLayer.CardService.CardDTO card);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICardMgmtContract/UpdateCard", ReplyAction="http://tempuri.org/ICardMgmtContract/UpdateCardResponse")]
        void UpdateCard(PresentationLayer.CardService.CardDTO card);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICardMgmtContract/UpdateCard", ReplyAction="http://tempuri.org/ICardMgmtContract/UpdateCardResponse")]
        System.Threading.Tasks.Task UpdateCardAsync(PresentationLayer.CardService.CardDTO card);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICardMgmtContractChannel : PresentationLayer.CardService.ICardMgmtContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CardMgmtContractClient : System.ServiceModel.ClientBase<PresentationLayer.CardService.ICardMgmtContract>, PresentationLayer.CardService.ICardMgmtContract {
        
        public CardMgmtContractClient() {
        }
        
        public CardMgmtContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CardMgmtContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CardMgmtContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CardMgmtContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddCard(PresentationLayer.CardService.CardDTO card) {
            base.Channel.AddCard(card);
        }
        
        public System.Threading.Tasks.Task AddCardAsync(PresentationLayer.CardService.CardDTO card) {
            return base.Channel.AddCardAsync(card);
        }
        
        public PresentationLayer.CardService.CardDTO FindCardById(int id) {
            return base.Channel.FindCardById(id);
        }
        
        public System.Threading.Tasks.Task<PresentationLayer.CardService.CardDTO> FindCardByIdAsync(int id) {
            return base.Channel.FindCardByIdAsync(id);
        }
        
        public PresentationLayer.CardService.CardDTO[] GetAllCards() {
            return base.Channel.GetAllCards();
        }
        
        public System.Threading.Tasks.Task<PresentationLayer.CardService.CardDTO[]> GetAllCardsAsync() {
            return base.Channel.GetAllCardsAsync();
        }
        
        public PresentationLayer.CardService.CardDTO[] GetCards(System.Func<PresentationLayer.CardService.CardDTO, bool> predicate) {
            return base.Channel.GetCards(predicate);
        }
        
        public System.Threading.Tasks.Task<PresentationLayer.CardService.CardDTO[]> GetCardsAsync(System.Func<PresentationLayer.CardService.CardDTO, bool> predicate) {
            return base.Channel.GetCardsAsync(predicate);
        }
        
        public void RemoveCard(PresentationLayer.CardService.CardDTO card) {
            base.Channel.RemoveCard(card);
        }
        
        public System.Threading.Tasks.Task RemoveCardAsync(PresentationLayer.CardService.CardDTO card) {
            return base.Channel.RemoveCardAsync(card);
        }
        
        public void UpdateCard(PresentationLayer.CardService.CardDTO card) {
            base.Channel.UpdateCard(card);
        }
        
        public System.Threading.Tasks.Task UpdateCardAsync(PresentationLayer.CardService.CardDTO card) {
            return base.Channel.UpdateCardAsync(card);
        }
    }
}