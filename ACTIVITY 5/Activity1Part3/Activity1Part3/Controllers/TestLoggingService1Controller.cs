using Activity1Part3.Services.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity1Part3.Controllers
{
    public class TestLoggingService1Controller : Controller
    {
        private readonly ILogger logger;

        public TestLoggingService1Controller(ILogger log) 
        {
            logger = log;
        }

        // GET: TestLoggingService1
        public string Index()
        {          
            return logger.Info("Test 3");
        }
    }
}