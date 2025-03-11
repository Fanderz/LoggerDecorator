using System;
using System.IO;

namespace Logger
{
    class PathFinder : ILogger
    {
        private string _filePath;
        private LogTypes _logType;

        public PathFinder(LogTypes logType, string filePath = null)
        {
            _filePath = filePath;
            _logType = logType;
        }

        public void WriteLog(string message)
        {
            if (_filePath != null)
                File.WriteAllText(_filePath, message);

            if (_filePath == null || _logType == LogTypes.Complex)
                Console.WriteLine(message);
        }
    }
}
