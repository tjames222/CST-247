using Activity1Part3.Services.Business;
using Activity1Part3.Services.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity1Part3.Controllers
{
    public class TestLoggingService3Controller : Controller
    {
        private readonly ILogger logger;
        private readonly ITestService service;

        public TestLoggingService3Controller(ILogger log, ITestService testService)
        {
            this.logger = log;
            this.service = testService;
        }

        // GET: TestLoggingService3
        public string Index()
        {
            logger.Info("Test 3");
            service.TestLogger();
            return "Test 3";
        }
    }
}