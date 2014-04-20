﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3031
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.EvalServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Eval", Namespace="http://schemas.datacontract.org/2004/07/EvalServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class Eval : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CommentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubmitterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimeSubmittedField;
        
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
        public string Comments {
            get {
                return this.CommentsField;
            }
            set {
                if ((object.ReferenceEquals(this.CommentsField, value) != true)) {
                    this.CommentsField = value;
                    this.RaisePropertyChanged("Comments");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Submitter {
            get {
                return this.SubmitterField;
            }
            set {
                if ((object.ReferenceEquals(this.SubmitterField, value) != true)) {
                    this.SubmitterField = value;
                    this.RaisePropertyChanged("Submitter");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TimeSubmitted {
            get {
                return this.TimeSubmittedField;
            }
            set {
                if ((this.TimeSubmittedField.Equals(value) != true)) {
                    this.TimeSubmittedField = value;
                    this.RaisePropertyChanged("TimeSubmitted");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EvalServiceReference.IEvalService")]
    public interface IEvalService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvalService/SubmitEval", ReplyAction="http://tempuri.org/IEvalService/SubmitEvalResponse")]
        void SubmitEval(Client.EvalServiceReference.Eval eval);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IEvalService/SubmitEval", ReplyAction="http://tempuri.org/IEvalService/SubmitEvalResponse")]
        System.IAsyncResult BeginSubmitEval(Client.EvalServiceReference.Eval eval, System.AsyncCallback callback, object asyncState);
        
        void EndSubmitEval(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvalService/GetEvals", ReplyAction="http://tempuri.org/IEvalService/GetEvalsResponse")]
        System.Collections.Generic.List<Client.EvalServiceReference.Eval> GetEvals();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IEvalService/GetEvals", ReplyAction="http://tempuri.org/IEvalService/GetEvalsResponse")]
        System.IAsyncResult BeginGetEvals(System.AsyncCallback callback, object asyncState);
        
        System.Collections.Generic.List<Client.EvalServiceReference.Eval> EndGetEvals(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvalService/RemoveEval", ReplyAction="http://tempuri.org/IEvalService/RemoveEvalResponse")]
        void RemoveEval(string id);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IEvalService/RemoveEval", ReplyAction="http://tempuri.org/IEvalService/RemoveEvalResponse")]
        System.IAsyncResult BeginRemoveEval(string id, System.AsyncCallback callback, object asyncState);
        
        void EndRemoveEval(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IEvalServiceChannel : Client.EvalServiceReference.IEvalService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class GetEvalsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetEvalsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.Generic.List<Client.EvalServiceReference.Eval> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.Generic.List<Client.EvalServiceReference.Eval>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class EvalServiceClient : System.ServiceModel.ClientBase<Client.EvalServiceReference.IEvalService>, Client.EvalServiceReference.IEvalService {
        
        private BeginOperationDelegate onBeginSubmitEvalDelegate;
        
        private EndOperationDelegate onEndSubmitEvalDelegate;
        
        private System.Threading.SendOrPostCallback onSubmitEvalCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetEvalsDelegate;
        
        private EndOperationDelegate onEndGetEvalsDelegate;
        
        private System.Threading.SendOrPostCallback onGetEvalsCompletedDelegate;
        
        private BeginOperationDelegate onBeginRemoveEvalDelegate;
        
        private EndOperationDelegate onEndRemoveEvalDelegate;
        
        private System.Threading.SendOrPostCallback onRemoveEvalCompletedDelegate;
        
        public EvalServiceClient() {
        }
        
        public EvalServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EvalServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EvalServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EvalServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> SubmitEvalCompleted;
        
        public event System.EventHandler<GetEvalsCompletedEventArgs> GetEvalsCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> RemoveEvalCompleted;
        
        public void SubmitEval(Client.EvalServiceReference.Eval eval) {
            base.Channel.SubmitEval(eval);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginSubmitEval(Client.EvalServiceReference.Eval eval, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginSubmitEval(eval, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndSubmitEval(System.IAsyncResult result) {
            base.Channel.EndSubmitEval(result);
        }
        
        private System.IAsyncResult OnBeginSubmitEval(object[] inValues, System.AsyncCallback callback, object asyncState) {
            Client.EvalServiceReference.Eval eval = ((Client.EvalServiceReference.Eval)(inValues[0]));
            return this.BeginSubmitEval(eval, callback, asyncState);
        }
        
        private object[] OnEndSubmitEval(System.IAsyncResult result) {
            this.EndSubmitEval(result);
            return null;
        }
        
        private void OnSubmitEvalCompleted(object state) {
            if ((this.SubmitEvalCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.SubmitEvalCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void SubmitEvalAsync(Client.EvalServiceReference.Eval eval) {
            this.SubmitEvalAsync(eval, null);
        }
        
        public void SubmitEvalAsync(Client.EvalServiceReference.Eval eval, object userState) {
            if ((this.onBeginSubmitEvalDelegate == null)) {
                this.onBeginSubmitEvalDelegate = new BeginOperationDelegate(this.OnBeginSubmitEval);
            }
            if ((this.onEndSubmitEvalDelegate == null)) {
                this.onEndSubmitEvalDelegate = new EndOperationDelegate(this.OnEndSubmitEval);
            }
            if ((this.onSubmitEvalCompletedDelegate == null)) {
                this.onSubmitEvalCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnSubmitEvalCompleted);
            }
            base.InvokeAsync(this.onBeginSubmitEvalDelegate, new object[] {
                        eval}, this.onEndSubmitEvalDelegate, this.onSubmitEvalCompletedDelegate, userState);
        }
        
        public System.Collections.Generic.List<Client.EvalServiceReference.Eval> GetEvals() {
            return base.Channel.GetEvals();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetEvals(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetEvals(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.Collections.Generic.List<Client.EvalServiceReference.Eval> EndGetEvals(System.IAsyncResult result) {
            return base.Channel.EndGetEvals(result);
        }
        
        private System.IAsyncResult OnBeginGetEvals(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetEvals(callback, asyncState);
        }
        
        private object[] OnEndGetEvals(System.IAsyncResult result) {
            System.Collections.Generic.List<Client.EvalServiceReference.Eval> retVal = this.EndGetEvals(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetEvalsCompleted(object state) {
            if ((this.GetEvalsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetEvalsCompleted(this, new GetEvalsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetEvalsAsync() {
            this.GetEvalsAsync(null);
        }
        
        public void GetEvalsAsync(object userState) {
            if ((this.onBeginGetEvalsDelegate == null)) {
                this.onBeginGetEvalsDelegate = new BeginOperationDelegate(this.OnBeginGetEvals);
            }
            if ((this.onEndGetEvalsDelegate == null)) {
                this.onEndGetEvalsDelegate = new EndOperationDelegate(this.OnEndGetEvals);
            }
            if ((this.onGetEvalsCompletedDelegate == null)) {
                this.onGetEvalsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetEvalsCompleted);
            }
            base.InvokeAsync(this.onBeginGetEvalsDelegate, null, this.onEndGetEvalsDelegate, this.onGetEvalsCompletedDelegate, userState);
        }
        
        public void RemoveEval(string id) {
            base.Channel.RemoveEval(id);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginRemoveEval(string id, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginRemoveEval(id, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndRemoveEval(System.IAsyncResult result) {
            base.Channel.EndRemoveEval(result);
        }
        
        private System.IAsyncResult OnBeginRemoveEval(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string id = ((string)(inValues[0]));
            return this.BeginRemoveEval(id, callback, asyncState);
        }
        
        private object[] OnEndRemoveEval(System.IAsyncResult result) {
            this.EndRemoveEval(result);
            return null;
        }
        
        private void OnRemoveEvalCompleted(object state) {
            if ((this.RemoveEvalCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.RemoveEvalCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void RemoveEvalAsync(string id) {
            this.RemoveEvalAsync(id, null);
        }
        
        public void RemoveEvalAsync(string id, object userState) {
            if ((this.onBeginRemoveEvalDelegate == null)) {
                this.onBeginRemoveEvalDelegate = new BeginOperationDelegate(this.OnBeginRemoveEval);
            }
            if ((this.onEndRemoveEvalDelegate == null)) {
                this.onEndRemoveEvalDelegate = new EndOperationDelegate(this.OnEndRemoveEval);
            }
            if ((this.onRemoveEvalCompletedDelegate == null)) {
                this.onRemoveEvalCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnRemoveEvalCompleted);
            }
            base.InvokeAsync(this.onBeginRemoveEvalDelegate, new object[] {
                        id}, this.onEndRemoveEvalDelegate, this.onRemoveEvalCompletedDelegate, userState);
        }
    }
}