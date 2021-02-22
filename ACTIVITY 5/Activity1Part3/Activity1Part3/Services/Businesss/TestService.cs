using Activity1Part3.Services.Business;
using Activity1Part3.Services.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;

namespace Activity1Part3.Services.Businesss
{
    public class TestService : ITestService
    {
        private ILogger logger;

        public TestService() { }

        [InjectionMethod]
        public void Init(ILogger logger)
        {
            this.logger = logger;
        }

        public void TestLogger()
        {
            logger.Info("Test Logging in TestService.TestLogger() invoked.");
        }
    }
}