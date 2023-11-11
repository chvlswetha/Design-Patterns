using System;

//startegy

interface PaymentStrategy
{
    public void ProcessPayment(double amount);
}

//concrete tsrategies

class CreditCardPayment : PaymentStrategy
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine("Processing Credit Card Payment for :" + amount);
    }

}

class PayPalPayment : PaymentStrategy
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine("Processing PayPal Payment for :" + amount);
    }

}

class CryptoPayment : PaymentStrategy
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine("Processing Crypto Payment for :" + amount);
    }

}

//Factory for creating startegies

class PaymentFactory
{
    public static PaymentStrategy CreateStartegy(string PaymentMethod)
    {
        if (PaymentMethod.Equals("Credit Card"))
            return new CreditCardPayment();

       else if (PaymentMethod.Equals("PayPal"))
            return new PayPalPayment();

        else if (PaymentMethod.Equals("Crypto"))
            return new CryptoPayment();
        else
            return new CreditCardPayment();
    }
}

//Context for behaviour - Context has Strategy
//It is creating Strategy inside the contect - Composition

class PaymentProcessor
{
    private PaymentStrategy strategy;

    public PaymentProcessor()
    {
        strategy = null;
    }

    public void SetPaymentStrategy(string paymethod)
    {
        if(strategy != null)
        {
            strategy = null;
        }
        strategy = PaymentFactory.CreateStartegy(paymethod);
    }

    public void ProcessAmount(double amount)
    {
        if (strategy != null)
        {
            strategy.ProcessPayment(amount);
        }
        else
            Console.WriteLine("Startegy Not Set");
    }
}

class Main_client
{
    public static void Main(string[] args)
    {
        PaymentProcessor pp = new PaymentProcessor();


        pp.SetPaymentStrategy("Credit Card");
        pp.ProcessAmount(100);


        pp.SetPaymentStrategy("PayPal");
        pp.ProcessAmount(100);


        pp.SetPaymentStrategy("Crypto");
        pp.ProcessAmount(200);
        pp.ProcessAmount(300);

        pp.SetPaymentStrategy("");
        pp.ProcessAmount(400);
    }
}