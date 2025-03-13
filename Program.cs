using System;

namespace Logger
{
    class Program
    {
        private static string _filePath = @"D:\NapilnikLog.txt";

        static void Main()
        {
            PathFinder consoleLog = new PathFinder(new ConsoleLogWriter());
            PathFinder fileLog = new PathFinder(new FileLogWriter(_filePath));
            PathFinder fridayConsole = new PathFinder(new SecureLogWriter(new ConsoleLogWriter()));
            PathFinder fridayFile = new PathFinder(new SecureLogWriter(new FileLogWriter(_filePath)));
            PathFinder fridayComplexLog = new PathFinder(new SecureLogWriter(new ComplexLogWriter(new ILogger[] { new ConsoleLogWriter(), new FileLogWriter(_filePath) })));

            consoleLog.Find();
            fileLog.Find();
            fridayConsole.Find();
            fridayFile.Find();
            fridayComplexLog.Find();

            Console.ReadKey();
        }
    }
}
