using System;
using System.Diagnostics;

namespace DefaultIntefaceMembers
{
    public interface ILogger
    {
        void Info(string message);
        void Error(string message);

        // New method
        void Warn(string message)
        {
            Debug.WriteLine(message);
        }
    }

    public class ConsoleLogger : ILogger
    {
        public void Error(string message)
        {
            Console.WriteLine(message);
        }

        public void Info(string message)
        {
            Console.WriteLine(message);
        }
    }

    class Sample
    {
        static void Main()
        {
            ILogger logger = new ConsoleLogger();
            logger.Warn("This is bad code");
        }
    }

}
