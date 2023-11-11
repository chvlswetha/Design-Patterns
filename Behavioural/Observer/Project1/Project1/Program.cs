using System;

interface Observer
{
    public void update(Subject order);
}
//Concrete Observers
class customer : Observer
{

    string name;
    public customer(string name)
    {
        this.name = name;
    }
    public void update(Subject order)
    {
        Console.WriteLine("Hello Customer:" + name + ": Your Order:" + order.getId() + " :is now:" + order.getStatus());
    }
}

class Restuarant : Observer
{

    string name;
    public Restuarant(string name)
    {
        this.name = name;
    }
    public void update(Subject order)
    {
        Console.WriteLine("Hello Restuarant:" + name + ": Your Order:" + order.getId() + " :is now:" + order.getStatus());
    }
}

class DeliveryDriver : Observer
{

    string name;
    public DeliveryDriver(string name)
    {
        this.name = name;
    }
    public void update(Subject order)
    {
        Console.WriteLine("Hello DeliveryDriver:" + name + ": Your Order:" + order.getId() + " :is now:" + order.getStatus());
    }
}

class CallCenter : Observer
{

    string name;
    public CallCenter(string name)
    {
        this.name = name;
    }
    public void update(Subject order)
    {
        Console.WriteLine("Hello CallCenter:" + name + ": Your Order:" + order.getId() + " :is now:" + order.getStatus());
    }
}

class Subject
{
    int id;
    String status;

    //subject containing list of observers - oberver collection
    List<Observer> observers = new List<Observer>();
    public Subject(int id)
    {
        this.id = id;
        this.status = "Order Placed";
    }
    public int getId()
    {
        return id;
    }
    public void setStatus(string newstatus)
    {
        this.status = newstatus;
        //whenever state changes we are notifying all obervers.
        NotifyObservers();
    }
    public string getStatus() 
    {
        return status;
    }

    //register and unregister Obeservers
    public void attach(Observer observer)
    {
        observers.Add(observer);
    }
    public void remove(Observer observer)
    {
        observers.Remove(observer);
    }
    public void NotifyObservers()
    {
        foreach(Observer observer in observers)
        {
            //calling uopdate function from mobservers here
            observer.update(this);
        }
    }
}
class main_client
{
    public static void Main(string[] args)
    {
        Observer Cust = new customer("cust#1");
        Observer Rest = new Restuarant("rest#1");
        Observer Driver = new DeliveryDriver("driver#1");
        Observer callcenter = new CallCenter("call center#1");

        Subject sub = new Subject(123);

        sub.attach(Cust);
        sub.attach(Rest);
        sub.attach(Driver); 
        sub.attach(callcenter);

        sub.setStatus("Preparing");

        Console.WriteLine("----------------Removed CallCenter ---------------");

        sub.remove(callcenter);

        sub.setStatus("Delivered");

    }
}