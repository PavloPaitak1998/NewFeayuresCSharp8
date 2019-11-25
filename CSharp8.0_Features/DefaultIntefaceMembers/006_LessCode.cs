using System;
using System.Diagnostics;
using System.IO;

namespace DefaultIntefaceMembers._006_LessCode
{
    public interface ILogger
    {
        void Log(string message);

        void LogWarning(string message)  // this doesn't need to be implemented,
        {                                // and therefore does not break 
            Log($"[Warning] {message}"); // compatibility
        }

        void LogError(Exception ex)  // same for this
        {
            Log($"[Error] {ex.Message}\n{ex.StackTrace}");
        }
    }

    public class FileLogger : ILogger
    {
        private StreamWriter file;

        public FileLogger(string fileName)
        {
            var fileStream = File.Open(fileName, FileMode.Append);

            file = new StreamWriter(fileStream);
        }

        public void Log(string message)
        {
            file.WriteLine(message);
        }
    }

    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    class TraceLogger : ILogger
    {
        public void Log(string message)
        {
            Trace.TraceInformation(message);
        }

        public void LogWarning(string message)
        {
            Trace.TraceWarning(message);
        }

        public void LogError(string message)
        {
            Trace.TraceError(message);
        }

    }
    class MyClass
    {
        public static void Foo()
        {
            ILogger logger = new FileLogger("log.txt");

            logger.LogWarning("This is a warning");
        }
    }
}
