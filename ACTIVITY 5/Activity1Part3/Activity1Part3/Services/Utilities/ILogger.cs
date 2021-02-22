using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity1Part3.Services.Utilities
{
    public interface ILogger
    {
        void Debug(string message);
        string Info(string message);
        void Warning(string message);
        void Error(string message);
    }
}
