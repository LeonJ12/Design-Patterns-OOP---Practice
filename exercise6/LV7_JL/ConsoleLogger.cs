using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV7_JL
{
    class ConsoleLogger : Logger
    {
        public void Log(SimpleSystemDataProvider provider)
        {
            Console.WriteLine("CPU load :" + provider.CPULoad + " Available ram" + provider.AvailableRAM);
        }
    }
}
