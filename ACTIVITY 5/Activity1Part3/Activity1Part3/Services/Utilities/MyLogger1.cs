using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Activity1Part3.Services.Utilities
{
    public sealed class MyLogger1 : ILogger
    {
        private static MyLogger1 instance = new MyLogger1();
        private static Logger getLogger = LogManager.GetCurrentClassLogger();
        static MyLogger1()
        {
        }
        private MyLogger1()
        {
        }
        public static MyLogger1 Instance(string rules)
        {
            instance.Info(rules);
            return instance;   
        }
        public static Logger GetLogger 
        {
            get
            {
                return getLogger;
            }
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