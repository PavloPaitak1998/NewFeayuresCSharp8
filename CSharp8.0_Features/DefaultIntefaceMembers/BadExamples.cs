using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace DefaultIntefaceMembers
{
    public interface ILogger
    {
        event Action<int> ActivityChanged
        {
            add { throw new NotImplementedException(); }
            remove { throw new NotImplementedException(); }
        }

        public int this[int i]
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        int MyProperty { 
            get 
            {
                throw new NotImplementedException();
            } 
            set 
            {
                throw new NotImplementedException();
            } 
        }

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
