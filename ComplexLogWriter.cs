using System;

namespace Logger
{
    class ComplexLogWriter : BaseLogWriter, ILogger
    {
        public ComplexLogWriter(PathFinder pathFinder)
        {
            PathFinder = pathFinder;
            LogType = LogTypes.Complex;
        }

        public void WriteLog(string message)
        {
            PathFinder.WriteLog(message);
        }
    }
}
