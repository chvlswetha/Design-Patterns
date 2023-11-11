using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Logger
{
    class DebugLogger : ILogger
    {
        public void log(string message)
        {
            Console.WriteLine("Debug:" + message);
        }
    }
}
