using System;

namespace Logger
{
    class PathFinder
    {
        private ILogger _logger;

        public PathFinder(ILogger logger)
        {
            _logger = logger;
        }

        public void Find()
        {
            _logger.WriteLog("Запись в лог.");
        }
    }
}
