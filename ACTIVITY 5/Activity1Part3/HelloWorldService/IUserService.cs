using Activity1Part3.Service1;
using Activity1Part3.Services.Businesss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HelloWorldService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract] 
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "SayHello/")] 
        string SayHello();

        [OperationContract] 
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetData/{value}")] 
        string GetData(string value);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetObjectModel/{id}")]
        CompositeType GetObjectModel(string id);

        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetUser/{id}")]
        DTO GetUser(string id);

        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "GetAllUsers/")]
        DTO GetAllUsers();
    }
}
