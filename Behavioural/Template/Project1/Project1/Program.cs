using System;
using System.Linq.Expressions;

abstract class PerfromOrderProcessingTemplate
{
    public void ProcessOrder()
    {
        VerifyOrder();
        AssignDeliveryAgent();
        TrackDelivery();
    }
    public abstract void VerifyOrder();
    public abstract void AssignDeliveryAgent();
    public abstract void TrackDelivery();

}
class LocalProcessing : PerfromOrderProcessingTemplate
{
    public override void VerifyOrder()
    {
        Console.WriteLine("Local Order  - Verifying");
    }
    public override void AssignDeliveryAgent()
    {
        Console.WriteLine("Local Order - Assign Delivery Agent");
    }

    public override void TrackDelivery()
    {
        Console.WriteLine("Local Order - Tracking Delivery");
    }
}

class InternationalProcessing : PerfromOrderProcessingTemplate
{
    public override void VerifyOrder()
    {
        Console.WriteLine("International  Order  - Verifying");
    }
    public override void AssignDeliveryAgent()
    {
        Console.WriteLine("International Order - Assign Delivery Agent");
    }

    public override void TrackDelivery()
    {
        Console.WriteLine("International Order - Tracking Delivery");
    }
}

class Main_client
{
    public static void Main(string[] args)
    {
        PerfromOrderProcessingTemplate local = new LocalProcessing();
        PerfromOrderProcessingTemplate international = new InternationalProcessing();

        local.ProcessOrder();
        international.ProcessOrder();
    }
}