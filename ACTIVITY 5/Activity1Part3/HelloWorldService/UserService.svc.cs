using Activity1Part3.Models;
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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {
        public List<UserModel> users = new List<UserModel>();
        public UserService()
        {
            users.Add(new UserModel("Joe Dirt", "pass"));
            users.Add(new UserModel("Sally Dirt", "pass2"));
            users.Add(new UserModel("Bob Dirt", "pass3"));
            users.Add(new UserModel("Dirt Dirt", "pass4"));
        }
        public DTO GetAllUsers()
        {
            DTO dto = new DTO();
            dto.ErrorCode = 0;
            dto.ErrorMessage = "OK";
            dto.Data = users;
            return dto;
        }
        public string GetData(string value)
        {
            return value;
        }
        public CompositeType GetObjectModel(string id)
        {
            throw new NotImplementedException();
        }
        public DTO GetUser(string id)
        {
            int ID = Int32.Parse(id);
            DTO dto = new DTO();

            if (ID < 0 || ID > users.Count())
            {
                dto.ErrorCode = -1;
                dto.ErrorMessage = "User Does Not Exist";
                dto.Data = null;
                return dto;
            }
            else 
            {
                UserModel user = users.ElementAt(ID);
                dto.ErrorCode = 0;
                dto.ErrorMessage = "Ok";
                dto.User = user;
                return dto;
            }
        }
        public string SayHello()
        {
            return "Hello World";
        }
    }
}
