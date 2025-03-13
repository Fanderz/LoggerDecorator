using System;

namespace Logger
{
    class PathFinder
    {
        private string _filePath;

        public PathFinder(string filePath)
        {
            _filePath = filePath;
        }

        public void Find()
        {
            ConsoleLogWriter consoleWriter = new ConsoleLogWriter();
            FileLogWriter fileWriter = new FileLogWriter(_filePath);
            ConsoleLogWriter consoleWednesdayWriter = new ConsoleLogWriter();
            FileLogWriter fileWednesdayWriter = new FileLogWriter(_filePath);
            ComplexLogWriter complexWednesdayWriter = new ComplexLogWriter(new ConsoleLogWriter(), new FileLogWriter(_filePath));

            consoleWriter.WriteLog("Запись в консоль.");
            fileWriter.WriteLog("Запись в файл.");

            if (IsThursday())
            {
                consoleWednesdayWriter.WriteLog("Запись в консоль в пятницу.");
                fileWednesdayWriter.WriteLog("Запись в файл в пятницу.");
                complexWednesdayWriter.WriteLog("Комплексная запись в пятницу.");
            }
        }

        private bool IsThursday() => DateTime.Now.DayOfWeek == DayOfWeek.Thursday;
    }
}
