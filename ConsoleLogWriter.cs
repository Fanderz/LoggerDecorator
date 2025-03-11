using System;

namespace Logger
{
    class ConsoleLogWriter : BaseLogWriter, ILogger
    {
        public ConsoleLogWriter(PathFinder pathFinder)
        {
            PathFinder = pathFinder;
            LogType = LogTypes.Console;
        }

        public void WriteLog(string message)
        {
            PathFinder.WriteLog(message);
        }
    }
}
