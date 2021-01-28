using Activity2Part1.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity2Part1.Controllers
{
    public class TestController : Controller
    {

        public List<UserModel> UserList = new List<UserModel>();
        
        // GET: Test
        public ActionResult Index()
        {
            UserList.Add(new UserModel("Tim James", "tjames@mail.com", "123-456-7890"));
            UserList.Add(new UserModel("Loren James", "tjames@mail.com", "123-456-7890"));
            UserList.Add(new UserModel("Amos James", "tjames@mail.com", "123-456-7890"));
            UserList.Add(new UserModel("Tom James", "tjames@mail.com", "123-456-7890"));
            UserList.Add(new UserModel("Betty Broker", "tjames@mail.com", "123-456-7890"));
            UserList.Add(new UserModel("Sandy Silverman", "tjames@mail.com", "123-456-7890"));
            UserList.Add(new UserModel("Greg John", "tjames@mail.com", "123-456-7890"));

            return View("Test", UserList);
        }
    }
}