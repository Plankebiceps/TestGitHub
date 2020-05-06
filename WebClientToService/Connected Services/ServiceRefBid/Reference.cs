﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebClientToService.ServiceRefBid {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Bid", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceWithDatabaseAccess.ModelLayer")]
    [System.SerializableAttribute()]
    public partial class Bid : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AuctionIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal BidAmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CustomerIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
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
        public int AuctionId {
            get {
                return this.AuctionIdField;
            }
            set {
                if ((this.AuctionIdField.Equals(value) != true)) {
                    this.AuctionIdField = value;
                    this.RaisePropertyChanged("AuctionId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal BidAmount {
            get {
                return this.BidAmountField;
            }
            set {
                if ((this.BidAmountField.Equals(value) != true)) {
                    this.BidAmountField = value;
                    this.RaisePropertyChanged("BidAmount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CustomerId {
            get {
                return this.CustomerIdField;
            }
            set {
                if ((this.CustomerIdField.Equals(value) != true)) {
                    this.CustomerIdField = value;
                    this.RaisePropertyChanged("CustomerId");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceRefBid.IBidService")]
    public interface IBidService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBidService/PlaceBid", ReplyAction="http://tempuri.org/IBidService/PlaceBidResponse")]
        bool PlaceBid(WebClientToService.ServiceRefBid.Bid bidToPlace);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBidService/PlaceBid", ReplyAction="http://tempuri.org/IBidService/PlaceBidResponse")]
        System.Threading.Tasks.Task<bool> PlaceBidAsync(WebClientToService.ServiceRefBid.Bid bidToPlace);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBidService/UpdateBid", ReplyAction="http://tempuri.org/IBidService/UpdateBidResponse")]
        bool UpdateBid(WebClientToService.ServiceRefBid.Bid aBidToUpdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBidService/UpdateBid", ReplyAction="http://tempuri.org/IBidService/UpdateBidResponse")]
        System.Threading.Tasks.Task<bool> UpdateBidAsync(WebClientToService.ServiceRefBid.Bid aBidToUpdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBidService/GetBidAll", ReplyAction="http://tempuri.org/IBidService/GetBidAllResponse")]
        WebClientToService.ServiceRefBid.Bid[] GetBidAll(int auctionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBidService/GetBidAll", ReplyAction="http://tempuri.org/IBidService/GetBidAllResponse")]
        System.Threading.Tasks.Task<WebClientToService.ServiceRefBid.Bid[]> GetBidAllAsync(int auctionId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBidService/GetBidById", ReplyAction="http://tempuri.org/IBidService/GetBidByIdResponse")]
        WebClientToService.ServiceRefBid.Bid GetBidById(int bidId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBidService/GetBidById", ReplyAction="http://tempuri.org/IBidService/GetBidByIdResponse")]
        System.Threading.Tasks.Task<WebClientToService.ServiceRefBid.Bid> GetBidByIdAsync(int bidId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBidServiceChannel : WebClientToService.ServiceRefBid.IBidService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BidServiceClient : System.ServiceModel.ClientBase<WebClientToService.ServiceRefBid.IBidService>, WebClientToService.ServiceRefBid.IBidService {
        
        public BidServiceClient() {
        }
        
        public BidServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BidServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BidServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BidServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool PlaceBid(WebClientToService.ServiceRefBid.Bid bidToPlace) {
            return base.Channel.PlaceBid(bidToPlace);
        }
        
        public System.Threading.Tasks.Task<bool> PlaceBidAsync(WebClientToService.ServiceRefBid.Bid bidToPlace) {
            return base.Channel.PlaceBidAsync(bidToPlace);
        }
        
        public bool UpdateBid(WebClientToService.ServiceRefBid.Bid aBidToUpdate) {
            return base.Channel.UpdateBid(aBidToUpdate);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateBidAsync(WebClientToService.ServiceRefBid.Bid aBidToUpdate) {
            return base.Channel.UpdateBidAsync(aBidToUpdate);
        }
        
        public WebClientToService.ServiceRefBid.Bid[] GetBidAll(int auctionId) {
            return base.Channel.GetBidAll(auctionId);
        }
        
        public System.Threading.Tasks.Task<WebClientToService.ServiceRefBid.Bid[]> GetBidAllAsync(int auctionId) {
            return base.Channel.GetBidAllAsync(auctionId);
        }
        
        public WebClientToService.ServiceRefBid.Bid GetBidById(int bidId) {
            return base.Channel.GetBidById(bidId);
        }
        
        public System.Threading.Tasks.Task<WebClientToService.ServiceRefBid.Bid> GetBidByIdAsync(int bidId) {
            return base.Channel.GetBidByIdAsync(bidId);
        }
    }
}
