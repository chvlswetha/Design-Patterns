using System;
using System.Transactions;

abstract class OrderHandler
{
    protected OrderHandler orderhandler;

    public OrderHandler(OrderHandler orderhandler)
    {
        this.orderhandler = orderhandler;
    }

    public abstract void ProcessOrder(String order);
}

//concreate classes

class OrderValidation : OrderHandler
{
    public OrderValidation(OrderHandler nexthandler) : base(nexthandler)
    {
    }
    public override void ProcessOrder(string order)
    {
        Console.WriteLine("Validating the Order for :" + order);

        if(orderhandler != null)
        {
            orderhandler.ProcessOrder(order);
        }
    }
}

class PaymentProcessing : OrderHandler
{

    public PaymentProcessing(OrderHandler nexthandler) : base(nexthandler)
    {
    }
    public override void ProcessOrder(string order)
    {
        Console.WriteLine("Payment Processing the Order for :" + order);

        if (orderhandler != null)
        {
            orderhandler.ProcessOrder(order);
        }
    }
}
class OrderPreparation : OrderHandler
{
    public OrderPreparation(OrderHandler nexthandler) : base(nexthandler)
    {
    }
    public override void ProcessOrder(string order)
    {
        Console.WriteLine("Preparing the Order for :" + order);

        if (orderhandler != null)
        {
            orderhandler.ProcessOrder(order);
        }
    }
}
class DeliveryAssignment : OrderHandler
{
    public DeliveryAssignment(OrderHandler nexthandler) : base(nexthandler)
    {
    }
    public override void ProcessOrder(string order)
    {
        Console.WriteLine("Assigining Delivery the Order for :" + order);

        if (orderhandler != null)
        {
            orderhandler.ProcessOrder(order);
        }
    }
}
class OrderTracking : OrderHandler
{
    public OrderTracking(OrderHandler nexthandler) : base(nexthandler)
    {
    }
    public override void ProcessOrder(string order)
    {
        Console.WriteLine("Tracking the Order for :" + order);

        if (orderhandler != null)
        {
            orderhandler.ProcessOrder(order);
        }
    }
}

class Main_client
{
    public static void Main(string[] args)
    {
        OrderHandler orderprocess = new OrderValidation
                                        (new PaymentProcessing
                                             (new OrderPreparation
                                                 (new OrderTracking(null))));

        orderprocess.ProcessOrder("Pizza");
    }
}