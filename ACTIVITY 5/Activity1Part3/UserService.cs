﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Activity1Part3.Service1
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/Activity1Part3.Service1")]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
    }
}
namespace Activity1Part3.Services.Businesss
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DTO", Namespace="http://schemas.datacontract.org/2004/07/Activity1Part3.Services.Businesss")]
    public partial class DTO : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private Activity1Part3.Models.UserModel[] DataField;
        
        private int ErrorCodeField;
        
        private string ErrorMessageField;
        
        private Activity1Part3.Models.UserModel UserField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Activity1Part3.Models.UserModel[] Data
        {
            get
            {
                return this.DataField;
            }
            set
            {
                this.DataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ErrorCode
        {
            get
            {
                return this.ErrorCodeField;
            }
            set
            {
                this.ErrorCodeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ErrorMessage
        {
            get
            {
                return this.ErrorMessageField;
            }
            set
            {
                this.ErrorMessageField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Activity1Part3.Models.UserModel User
        {
            get
            {
                return this.UserField;
            }
            set
            {
                this.UserField = value;
            }
        }
    }
}
namespace Activity1Part3.Models
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserModel", Namespace="http://schemas.datacontract.org/2004/07/Activity1Part3.Models")]
    public partial class UserModel : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string PasswordField;
        
        private string UsernameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password
        {
            get
            {
                return this.PasswordField;
            }
            set
            {
                this.PasswordField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username
        {
            get
            {
                return this.UsernameField;
            }
            set
            {
                this.UsernameField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IUserService")]
public interface IUserService
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/SayHello", ReplyAction="http://tempuri.org/IUserService/SayHelloResponse")]
    string SayHello();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/SayHello", ReplyAction="http://tempuri.org/IUserService/SayHelloResponse")]
    System.Threading.Tasks.Task<string> SayHelloAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetData", ReplyAction="http://tempuri.org/IUserService/GetDataResponse")]
    string GetData(string value);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetData", ReplyAction="http://tempuri.org/IUserService/GetDataResponse")]
    System.Threading.Tasks.Task<string> GetDataAsync(string value);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetObjectModel", ReplyAction="http://tempuri.org/IUserService/GetObjectModelResponse")]
    Activity1Part3.Service1.CompositeType GetObjectModel(string id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetObjectModel", ReplyAction="http://tempuri.org/IUserService/GetObjectModelResponse")]
    System.Threading.Tasks.Task<Activity1Part3.Service1.CompositeType> GetObjectModelAsync(string id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUser", ReplyAction="http://tempuri.org/IUserService/GetUserResponse")]
    Activity1Part3.Services.Businesss.DTO GetUser(string id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetUser", ReplyAction="http://tempuri.org/IUserService/GetUserResponse")]
    System.Threading.Tasks.Task<Activity1Part3.Services.Businesss.DTO> GetUserAsync(string id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetAllUsers", ReplyAction="http://tempuri.org/IUserService/GetAllUsersResponse")]
    Activity1Part3.Services.Businesss.DTO GetAllUsers();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUserService/GetAllUsers", ReplyAction="http://tempuri.org/IUserService/GetAllUsersResponse")]
    System.Threading.Tasks.Task<Activity1Part3.Services.Businesss.DTO> GetAllUsersAsync();
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IUserServiceChannel : IUserService, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class UserServiceClient : System.ServiceModel.ClientBase<IUserService>, IUserService
{
    
    public UserServiceClient()
    {
    }
    
    public UserServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public UserServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public UserServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public string SayHello()
    {
        return base.Channel.SayHello();
    }
    
    public System.Threading.Tasks.Task<string> SayHelloAsync()
    {
        return base.Channel.SayHelloAsync();
    }
    
    public string GetData(string value)
    {
        return base.Channel.GetData(value);
    }
    
    public System.Threading.Tasks.Task<string> GetDataAsync(string value)
    {
        return base.Channel.GetDataAsync(value);
    }
    
    public Activity1Part3.Service1.CompositeType GetObjectModel(string id)
    {
        return base.Channel.GetObjectModel(id);
    }
    
    public System.Threading.Tasks.Task<Activity1Part3.Service1.CompositeType> GetObjectModelAsync(string id)
    {
        return base.Channel.GetObjectModelAsync(id);
    }
    
    public Activity1Part3.Services.Businesss.DTO GetUser(string id)
    {
        return base.Channel.GetUser(id);
    }
    
    public System.Threading.Tasks.Task<Activity1Part3.Services.Businesss.DTO> GetUserAsync(string id)
    {
        return base.Channel.GetUserAsync(id);
    }
    
    public Activity1Part3.Services.Businesss.DTO GetAllUsers()
    {
        return base.Channel.GetAllUsers();
    }
    
    public System.Threading.Tasks.Task<Activity1Part3.Services.Businesss.DTO> GetAllUsersAsync()
    {
        return base.Channel.GetAllUsersAsync();
    }
}
