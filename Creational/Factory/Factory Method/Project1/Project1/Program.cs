using Project1.Logger;
using Project1.Factory;
using System;

class Main_client
{
    static void Main(string[] args)
    {
        LoggerFactory debug = new DebugFactory();
        LoggerFactory info = new InfoFactory();
        LoggerFactory error = new ErrorFactory();

       ILogger debuglog = debug.CreateLogger();
        ILogger infolog = info.CreateLogger();
        ILogger errorlog = error.CreateLogger();

        debuglog.log("this is debug");
        infolog.log("this is info");
        errorlog.log("this is error");
    }
}
