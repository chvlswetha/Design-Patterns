using System;
using System.Runtime.CompilerServices;

interface command
{
    public void execute();
}

//concrete commands
class RideRequest : command
{
    RideService receiver;
    string passenger;
    string source;
    string dest;

    public RideRequest(RideService service,  string passenger, string source, string dest)
    {
        receiver = service; 
        this.passenger = passenger;
        this.source = source;
        this.dest = dest;
    }
    public void execute()
    {
        receiver.RideRequested(passenger,source,dest);
    }
}

class CancelRequest : command
{
    RideService receiver;
    string passenger;

    public CancelRequest(RideService service, string passenger)
    {
        receiver = service;
        this.passenger = passenger;
    }
    public void execute()
    {
        receiver.CancelRequested(passenger);

    }
}

//Receiver - perfroming action

class  RideService
{
    public void RideRequested(string passenger, string source, string dest)
    {
        Console.WriteLine("Ride requested for passenger:" + passenger + ":from:" + source + ":to:" + dest);
    }

    public void CancelRequested(string passenger)
    {
        Console.WriteLine("Cancelling ride from passenger:" + passenger);
    }
}

//Invoker - Call methods of command

class Invoker
{  
    public void processRequest(command ReqCancel)
    {
        ReqCancel.execute();
    }
}

class Main_client
{
    public static void Main(string[] args)
    {
        RideService Rs = new RideService();

        command req1 = new RideRequest(Rs, "Swetha", "Hyderabad", "Chennai");
        command req2 = new RideRequest(Rs, "Kames", "Hyderabad", "Chennai");
        command cancel1 = new CancelRequest(Rs, "Swetha");

        //Invoker

        Invoker In = new Invoker();

        In.processRequest(req1);
        In.processRequest(req2);
        In.processRequest(cancel1);
          
    }
}