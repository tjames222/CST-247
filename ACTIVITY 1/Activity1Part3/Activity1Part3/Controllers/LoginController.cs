using Activity1Part3.Models;
using Activity1Part3.Services.Businesss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity1Part3.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View("Login");
        }

        public ActionResult Login(UserModel model)
        {
            SecurityService auth = new SecurityService();
            
            bool result = auth.Authenticate(model);

            if (result)
            {
                return View("LoginPassed");
            }
            else
            {
                return View("LoginFailed");
            }
        }
    }
}