using System;

namespace Logger
{
    class Program
    {
        private static string _filePath = @"D:\NapilnikLog.txt";

        static void Main()
        {
            PathFinder pathFinder = new PathFinder(_filePath);
            pathFinder.Find();

            Console.ReadKey();
        }
    }
}
