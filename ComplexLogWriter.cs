using System;

namespace Logger
{
    class ComplexLogWriter : ILogger
    {
        private ILogger[] _loggers;

        public ComplexLogWriter(ILogger[] loggers)
        {
            _loggers = loggers;
        }

        public void WriteLog(string message)
        {
            for (int i = 0; i < _loggers.Length; i++)
                _loggers[i].WriteLog(message);
        }
    }
}
