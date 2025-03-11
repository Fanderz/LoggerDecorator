using System;

namespace Logger
{
    class Program
    {
        static void Main()
        {
            ConsoleLogWriter consoleWriter = new ConsoleLogWriter(new PathFinder(LogTypes.Console));
            FileLogWriter fileWriter = new FileLogWriter(new PathFinder(LogTypes.File, @"D:\NapilnikLog.txt"));
            ConsoleLogWriter consoleFridayWriter = new ConsoleLogWriter(new PathFinder(LogTypes.Console));
            FileLogWriter fileFridayWriter = new FileLogWriter(new PathFinder(LogTypes.File, @"D:\FridayNapilnikLog.txt"));
            ComplexLogWriter complexFridayWriter = new ComplexLogWriter(new PathFinder(LogTypes.Complex, @"D:\ComplexNapilnikLog.txt"));

            consoleWriter.WriteLog("Запись в консоль.");
            fileWriter.WriteLog("Запись в файл.");

            if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
            {
                consoleFridayWriter.WriteLog("Запись в консоль в пятницу.");
                fileFridayWriter.WriteLog("Запись в файл в пятницу.");
                complexFridayWriter.WriteLog("Комплексная запись в пятницу.");
            }

            Console.ReadKey();
        }
    }
}
