using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5_JL
{
    internal class ConsoleLogger
    {
        private static ConsoleLogger instance;
        private ConsoleLogger() { }
        public static ConsoleLogger GetInstance()
        {
            if (instance == null)
            {
                return new ConsoleLogger();
            }
            return instance;

        }
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
