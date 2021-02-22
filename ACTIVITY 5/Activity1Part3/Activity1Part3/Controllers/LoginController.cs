using Activity1Part3.Models;
using Activity1Part3.Services.Businesss;
using NLog;
using System.Web.Script.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Activity1Part3.Services.Utilities;

namespace Activity1Part3.Controllers
{
    public class LoginController : Controller
    {
        
        //private static MyLogger1 logger = MyLogger1.Instance("myAppLoggerRules");
        private static Logger logger = LogManager.GetLogger("myAppLoggerRules");

        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View("Login");
        }

        public ActionResult Login(UserModel model)
        {
            
            logger.Info("Entering LoginController.Login()");
            
            try
            {
                // Validate the Form POST
                if (!ModelState.IsValid)
                    return View("Login");
                
                SecurityService auth = new SecurityService();  
                bool result = auth.Authenticate(model);
                logger.Info("Parameters are:" +  new JavaScriptSerializer().Serialize(model));
                if (result)
                {
                    logger.Info("Exit LoginController.Login() with Login passing");
                    return View("LoginPassed");
                }
                else
                {
                    logger.Info("Exit LoginController.Login() with Login failing");
                    return View("LoginFailed");
                }
            }
            catch (Exception e)
            {
                logger.Error("Exception LoginController.Login()" +  e.Message);
                return View("LoginFailed");
            }
        }
    }
}