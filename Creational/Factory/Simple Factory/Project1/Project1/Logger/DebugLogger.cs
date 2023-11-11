using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Logger
{
    public class DebugLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Debug:" + message);
        }
    }
}
