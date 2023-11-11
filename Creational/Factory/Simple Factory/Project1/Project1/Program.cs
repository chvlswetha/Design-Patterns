using System;
using Project1.Logger;

class Main_proj
{
    static void Main(string[] args)
    {
        ILogger Debuglog = LoggerFactory.CreateLogger(LogLevel.DEBUG);
        ILogger Infolog = LoggerFactory.CreateLogger(LogLevel.INFO);
        ILogger Errorlog = LoggerFactory.CreateLogger(LogLevel.ERROR);

        Debuglog.Log("This is Debug Log");
        Infolog.Log("This is Info Log");
        Errorlog.Log("This is Error Log");
    }
}