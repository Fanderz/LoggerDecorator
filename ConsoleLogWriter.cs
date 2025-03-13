using System;

namespace Logger
{
    class ConsoleLogWriter : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(message);
        }
    }
}
