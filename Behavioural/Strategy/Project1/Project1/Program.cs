using System;
using System.Diagnostics;

interface PaymentStrategy
{
    public void ProcessPayment(double amount);
}

class CreditcardPayment : PaymentStrategy
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine("processing Credit Card Payment of: " + amount);
    }
}

class PaypalPayment : PaymentStrategy
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine("processing PayPal Payment of: " + amount);
    }
}

class CryptoCurrencyPayment : PaymentStrategy
{
    public void ProcessPayment(double amount)
    {
        Console.WriteLine("processing Crypto Currency Payment of: " + amount);
    }
}

class PaymentProcessor
{
    PaymentStrategy paymentstrategy;

    public PaymentProcessor()
    {
        paymentstrategy = null;
    }

    public void setstrategy(PaymentStrategy strategy)
    {
        if(paymentstrategy != null)
        {
            paymentstrategy = null;
        }
        paymentstrategy = strategy;
    }

    public void process(double amount)
    {
        if( paymentstrategy != null )
        {
            paymentstrategy.ProcessPayment(amount); 
        }
        else
        {
            Console.WriteLine("Payemnt Strategy not set");
        }
    }
}
class Main_client
{
    public static void Main(String[] args)
    {
        PaymentProcessor processpay = new PaymentProcessor();

        PaymentStrategy CC = new CreditcardPayment();

        processpay.setstrategy(CC);
        processpay.process(100.00);

        PaymentStrategy PP = new PaypalPayment();

        processpay.setstrategy(PP);
        processpay.process(100.00);

        PaymentStrategy CR = new CryptoCurrencyPayment();

        processpay.setstrategy(CR);
        processpay.process(100.00);
    }
}