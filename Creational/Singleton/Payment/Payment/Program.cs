using System;
using System.ComponentModel;

class PaymentGatewayManager
{
    private PaymentGatewayManager()
    {
        Console.WriteLine("payment Gateway Manager Initialized");
    }
    private static PaymentGatewayManager instance;

    public static PaymentGatewayManager getInstance()
    {
        if (instance == null) 
        {
            instance = new PaymentGatewayManager();
        }
        return instance;
    }

    public void ProcessPayment(double paymentamount)
    {
        Console.WriteLine("processed payment for:" +  paymentamount);
    }
    static void Main(string[] args)
    {

        PaymentGatewayManager first_instance = PaymentGatewayManager.getInstance();

        first_instance.ProcessPayment(100.00);

        PaymentGatewayManager another_instance = PaymentGatewayManager.getInstance();

        if (first_instance ==  another_instance) 
        {

            Console.WriteLine("Both instances are same. Singleton Pattern Working Correctly");
        }
        else
        {
            Console.WriteLine("Both instances are not same. Singleton Pattern not Working");
        }
    }

}