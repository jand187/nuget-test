using System;

namespace MyLib
{
    public interface ILoggingService
    {
        void Log(string message);
    }

    internal class LoggingService : ILoggingService
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
