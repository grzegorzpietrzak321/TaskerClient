﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TaskerClient.TaskerReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Task", Namespace="http://schemas.datacontract.org/2004/07/Tasker")]
    [System.SerializableAttribute()]
    public partial class Task : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreateDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime deadlineDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool isFinishedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int priorityField;
        
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
        public System.DateTime CreateDate {
            get {
                return this.CreateDateField;
            }
            set {
                if ((this.CreateDateField.Equals(value) != true)) {
                    this.CreateDateField = value;
                    this.RaisePropertyChanged("CreateDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime deadlineDate {
            get {
                return this.deadlineDateField;
            }
            set {
                if ((this.deadlineDateField.Equals(value) != true)) {
                    this.deadlineDateField = value;
                    this.RaisePropertyChanged("deadlineDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.descriptionField, value) != true)) {
                    this.descriptionField = value;
                    this.RaisePropertyChanged("description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool isFinished {
            get {
                return this.isFinishedField;
            }
            set {
                if ((this.isFinishedField.Equals(value) != true)) {
                    this.isFinishedField = value;
                    this.RaisePropertyChanged("isFinished");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int priority {
            get {
                return this.priorityField;
            }
            set {
                if ((this.priorityField.Equals(value) != true)) {
                    this.priorityField = value;
                    this.RaisePropertyChanged("priority");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TaskerReference.ITaskerService")]
    public interface ITaskerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITaskerService/CreateTask", ReplyAction="http://tempuri.org/ITaskerService/CreateTaskResponse")]
        bool CreateTask(TaskerClient.TaskerReference.Task t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITaskerService/CreateTask", ReplyAction="http://tempuri.org/ITaskerService/CreateTaskResponse")]
        System.Threading.Tasks.Task<bool> CreateTaskAsync(TaskerClient.TaskerReference.Task t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITaskerService/EditTask", ReplyAction="http://tempuri.org/ITaskerService/EditTaskResponse")]
        bool EditTask(TaskerClient.TaskerReference.Task t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITaskerService/EditTask", ReplyAction="http://tempuri.org/ITaskerService/EditTaskResponse")]
        System.Threading.Tasks.Task<bool> EditTaskAsync(TaskerClient.TaskerReference.Task t);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITaskerService/FinishTask", ReplyAction="http://tempuri.org/ITaskerService/FinishTaskResponse")]
        bool FinishTask(int taskId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITaskerService/FinishTask", ReplyAction="http://tempuri.org/ITaskerService/FinishTaskResponse")]
        System.Threading.Tasks.Task<bool> FinishTaskAsync(int taskId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITaskerService/ShowTask", ReplyAction="http://tempuri.org/ITaskerService/ShowTaskResponse")]
        string ShowTask(int taskId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITaskerService/ShowTask", ReplyAction="http://tempuri.org/ITaskerService/ShowTaskResponse")]
        System.Threading.Tasks.Task<string> ShowTaskAsync(int taskId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITaskerService/GetTasks", ReplyAction="http://tempuri.org/ITaskerService/GetTasksResponse")]
        string GetTasks(int priorityId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITaskerService/GetTasks", ReplyAction="http://tempuri.org/ITaskerService/GetTasksResponse")]
        System.Threading.Tasks.Task<string> GetTasksAsync(int priorityId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITaskerServiceChannel : TaskerClient.TaskerReference.ITaskerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TaskerServiceClient : System.ServiceModel.ClientBase<TaskerClient.TaskerReference.ITaskerService>, TaskerClient.TaskerReference.ITaskerService {
        
        public TaskerServiceClient() {
        }
        
        public TaskerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TaskerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TaskerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TaskerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CreateTask(TaskerClient.TaskerReference.Task t) {
            return base.Channel.CreateTask(t);
        }
        
        public System.Threading.Tasks.Task<bool> CreateTaskAsync(TaskerClient.TaskerReference.Task t) {
            return base.Channel.CreateTaskAsync(t);
        }
        
        public bool EditTask(TaskerClient.TaskerReference.Task t) {
            return base.Channel.EditTask(t);
        }
        
        public System.Threading.Tasks.Task<bool> EditTaskAsync(TaskerClient.TaskerReference.Task t) {
            return base.Channel.EditTaskAsync(t);
        }
        
        public bool FinishTask(int taskId) {
            return base.Channel.FinishTask(taskId);
        }
        
        public System.Threading.Tasks.Task<bool> FinishTaskAsync(int taskId) {
            return base.Channel.FinishTaskAsync(taskId);
        }
        
        public string ShowTask(int taskId) {
            return base.Channel.ShowTask(taskId);
        }
        
        public System.Threading.Tasks.Task<string> ShowTaskAsync(int taskId) {
            return base.Channel.ShowTaskAsync(taskId);
        }
        
        public string GetTasks(int priorityId) {
            return base.Channel.GetTasks(priorityId);
        }
        
        public System.Threading.Tasks.Task<string> GetTasksAsync(int priorityId) {
            return base.Channel.GetTasksAsync(priorityId);
        }
    }
}
