﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Samples.Kinect.BodyBasics.DataService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BodyDataObject", Namespace="http://schemas.datacontract.org/2004/07/DataService")]
    [System.SerializableAttribute()]
    public partial class BodyDataObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string JointPointsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string JointsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SessionNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimeStampField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public string JointPoints {
            get {
                return this.JointPointsField;
            }
            set {
                if ((object.ReferenceEquals(this.JointPointsField, value) != true)) {
                    this.JointPointsField = value;
                    this.RaisePropertyChanged("JointPoints");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Joints {
            get {
                return this.JointsField;
            }
            set {
                if ((object.ReferenceEquals(this.JointsField, value) != true)) {
                    this.JointsField = value;
                    this.RaisePropertyChanged("Joints");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SessionName {
            get {
                return this.SessionNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SessionNameField, value) != true)) {
                    this.SessionNameField = value;
                    this.RaisePropertyChanged("SessionName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TimeStamp {
            get {
                return this.TimeStampField;
            }
            set {
                if ((this.TimeStampField.Equals(value) != true)) {
                    this.TimeStampField = value;
                    this.RaisePropertyChanged("TimeStamp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="uspGetBodyDataByUserNameAndSessionName_Result", Namespace="http://schemas.datacontract.org/2004/07/DataService")]
    [System.SerializableAttribute()]
    public partial class uspGetBodyDataByUserNameAndSessionName_Result : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string JointPointsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string JointsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SessionNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> timestampField;
        
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
        public string JointPoints {
            get {
                return this.JointPointsField;
            }
            set {
                if ((object.ReferenceEquals(this.JointPointsField, value) != true)) {
                    this.JointPointsField = value;
                    this.RaisePropertyChanged("JointPoints");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Joints {
            get {
                return this.JointsField;
            }
            set {
                if ((object.ReferenceEquals(this.JointsField, value) != true)) {
                    this.JointsField = value;
                    this.RaisePropertyChanged("Joints");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SessionName {
            get {
                return this.SessionNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SessionNameField, value) != true)) {
                    this.SessionNameField = value;
                    this.RaisePropertyChanged("SessionName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserID {
            get {
                return this.UserIDField;
            }
            set {
                if ((this.UserIDField.Equals(value) != true)) {
                    this.UserIDField = value;
                    this.RaisePropertyChanged("UserID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> timestamp {
            get {
                return this.timestampField;
            }
            set {
                if ((this.timestampField.Equals(value) != true)) {
                    this.timestampField = value;
                    this.RaisePropertyChanged("timestamp");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/DataService")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
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
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DataService.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        Microsoft.Samples.Kinect.BodyBasics.DataService.BodyDataObject[] GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<Microsoft.Samples.Kinect.BodyBasics.DataService.BodyDataObject[]> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SendData", ReplyAction="http://tempuri.org/IService1/SendDataResponse")]
        string SendData(string username, string sessionname, string joints, string jointPoints, System.DateTime dt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SendData", ReplyAction="http://tempuri.org/IService1/SendDataResponse")]
        System.Threading.Tasks.Task<string> SendDataAsync(string username, string sessionname, string joints, string jointPoints, System.DateTime dt);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPatients", ReplyAction="http://tempuri.org/IService1/GetPatientsResponse")]
        string[] GetPatients();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetPatients", ReplyAction="http://tempuri.org/IService1/GetPatientsResponse")]
        System.Threading.Tasks.Task<string[]> GetPatientsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSessions", ReplyAction="http://tempuri.org/IService1/GetSessionsResponse")]
        string[] GetSessions(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSessions", ReplyAction="http://tempuri.org/IService1/GetSessionsResponse")]
        System.Threading.Tasks.Task<string[]> GetSessionsAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBodyData", ReplyAction="http://tempuri.org/IService1/GetBodyDataResponse")]
        Microsoft.Samples.Kinect.BodyBasics.DataService.uspGetBodyDataByUserNameAndSessionName_Result[] GetBodyData(string username, string sessionname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetBodyData", ReplyAction="http://tempuri.org/IService1/GetBodyDataResponse")]
        System.Threading.Tasks.Task<Microsoft.Samples.Kinect.BodyBasics.DataService.uspGetBodyDataByUserNameAndSessionName_Result[]> GetBodyDataAsync(string username, string sessionname);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        Microsoft.Samples.Kinect.BodyBasics.DataService.CompositeType GetDataUsingDataContract(Microsoft.Samples.Kinect.BodyBasics.DataService.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Microsoft.Samples.Kinect.BodyBasics.DataService.CompositeType> GetDataUsingDataContractAsync(Microsoft.Samples.Kinect.BodyBasics.DataService.CompositeType composite);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Microsoft.Samples.Kinect.BodyBasics.DataService.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Microsoft.Samples.Kinect.BodyBasics.DataService.IService1>, Microsoft.Samples.Kinect.BodyBasics.DataService.IService1 {
        
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
        
        public Microsoft.Samples.Kinect.BodyBasics.DataService.BodyDataObject[] GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<Microsoft.Samples.Kinect.BodyBasics.DataService.BodyDataObject[]> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public string SendData(string username, string sessionname, string joints, string jointPoints, System.DateTime dt) {
            return base.Channel.SendData(username, sessionname, joints, jointPoints, dt);
        }
        
        public System.Threading.Tasks.Task<string> SendDataAsync(string username, string sessionname, string joints, string jointPoints, System.DateTime dt) {
            return base.Channel.SendDataAsync(username, sessionname, joints, jointPoints, dt);
        }
        
        public string[] GetPatients() {
            return base.Channel.GetPatients();
        }
        
        public System.Threading.Tasks.Task<string[]> GetPatientsAsync() {
            return base.Channel.GetPatientsAsync();
        }
        
        public string[] GetSessions(string username) {
            return base.Channel.GetSessions(username);
        }
        
        public System.Threading.Tasks.Task<string[]> GetSessionsAsync(string username) {
            return base.Channel.GetSessionsAsync(username);
        }
        
        public Microsoft.Samples.Kinect.BodyBasics.DataService.uspGetBodyDataByUserNameAndSessionName_Result[] GetBodyData(string username, string sessionname) {
            return base.Channel.GetBodyData(username, sessionname);
        }
        
        public System.Threading.Tasks.Task<Microsoft.Samples.Kinect.BodyBasics.DataService.uspGetBodyDataByUserNameAndSessionName_Result[]> GetBodyDataAsync(string username, string sessionname) {
            return base.Channel.GetBodyDataAsync(username, sessionname);
        }
        
        public Microsoft.Samples.Kinect.BodyBasics.DataService.CompositeType GetDataUsingDataContract(Microsoft.Samples.Kinect.BodyBasics.DataService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Microsoft.Samples.Kinect.BodyBasics.DataService.CompositeType> GetDataUsingDataContractAsync(Microsoft.Samples.Kinect.BodyBasics.DataService.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
    }
}