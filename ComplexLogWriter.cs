using System;

namespace Logger
{
    class ComplexLogWriter : ILogger
    {
        private ILogger _consoleLogger;
        private ILogger _fileLogger;

        public ComplexLogWriter(ILogger consoleLogger, ILogger fileLogger)
        {
            _consoleLogger = consoleLogger;
            _fileLogger = fileLogger;
        }

        public void WriteLog(string message)
        {
            _consoleLogger.WriteLog(message);
            _fileLogger.WriteLog(message);
        }
    }
}
