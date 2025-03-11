using System;

namespace Logger
{
    class FileLogWriter : BaseLogWriter, ILogger
    {
        public FileLogWriter(PathFinder pathFinder)
        {
            PathFinder = pathFinder;
            LogType = LogTypes.File;
        }

        public void WriteLog(string message)
        {
            PathFinder.WriteLog(message);
        }
    }
}
