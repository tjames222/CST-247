using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Activity1Part3.Models
{
    [DataContract]
    public class UserModel
    {
        [DataMember]
        [Required]
        [DisplayName("User Name")]
        [StringLength(20,MinimumLength = 4)]
        [DefaultValue("")]
        public string Username { get; set; }

        [DataMember]
        [Required]
        [DisplayName("Password")]
        [StringLength(20, MinimumLength = 4)]
        [DefaultValue("")]
        public string Password { get; set; }

        private static Logger logger = LogManager.GetLogger("myAppLoggerRules");

        public UserModel(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}