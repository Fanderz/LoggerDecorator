using System.IO;

namespace Logger
{
    class FileLogWriter : ILogger
    {
        private string _filePath;

        public FileLogWriter(string filePath)
        {
            _filePath = filePath;
        }

        public void WriteLog(string message)
        {
            File.WriteAllText(_filePath,message);
        }
    }
}
