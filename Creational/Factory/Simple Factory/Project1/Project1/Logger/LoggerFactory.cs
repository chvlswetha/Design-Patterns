using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Logger
{

    public class LoggerFactory
    {
        public static ILogger CreateLogger(LogLevel loglevel)
        {
            switch(loglevel)
            {
                case LogLevel.DEBUG: return new DebugLogger();
                case LogLevel.INFO : return new InfoLogger();
                case LogLevel.ERROR : return new ErrorLogger();

                default: return null;
            }
        }
    }
}
