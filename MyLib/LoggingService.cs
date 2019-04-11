using System;
using MyLib.Common;

namespace MyLib
{
    public class LoggingService : ILoggingService
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
