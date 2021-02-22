using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activity1Part3.Services.Utilities
{
    public sealed class MyLogger2 : ILogger
    {

        private Logger getLogger = LogManager.GetCurrentClassLogger();
        static MyLogger2()
        {
        }
        public Logger GetLogger() 
        {
                return getLogger;      
        }
        public void Debug(string message)
        {           
        }
        public void Error(string message)
        {         
        }
        public string Info(string message)
        {
            return message;
        }
        public void Warning(string message)
        {  
        }
    }
}