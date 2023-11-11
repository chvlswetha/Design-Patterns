using System;

interface NetworkDevice
{
    public abstract NetworkDevice Clone();
    public abstract void display();

    public abstract void update(string name);

}
class Router : NetworkDevice
{
    private string name;
    private string ip;
    private string securitypolicy;

    public Router(string name, string ip, string securitypolicy)
    {
        this.name = name;
        this.ip = ip;
        this.securitypolicy = securitypolicy;

    }
    public NetworkDevice Clone()
    {
        return new Router(name, ip, securitypolicy);
    }
    public  void display()
    {
        Console.WriteLine("Router - Name:" + name + ",IP:" + ip + ",Security Policy : " + securitypolicy);
    }
    public void update(string Newname)
    {
        name = Newname;
    }
}

class Switch : NetworkDevice
{
    private string name;
    private string Protocol;

    public Switch(string name, string Protocol) 
    { 
         this.name=name;
        this.Protocol = Protocol;   
    }
    public NetworkDevice Clone()
    {
        return new Switch(name, Protocol);
    }
    public void display()
    {
        Console.WriteLine("Switch - Name:" + name + ",Protcol:" + Protocol);
    }
    public void update(string Newname)
    {
        name = Newname;
    }

}
class Routerdemo
{
    static void Main(string[] args)
    {

        // Create prototype instances of a router and a switch
        NetworkDevice routerprototype = new Router("Router A", "192.168.1.1", "Firewall Enabled");
        NetworkDevice switchprototype = new Switch("Switch A", "Ethernet");

        Console.WriteLine("Original Values:");
        routerprototype.display();
        switchprototype.display();

        // Clone and display router and switch devices

        NetworkDevice cloneedrouter = routerprototype.Clone();
        NetworkDevice clonedswitch = switchprototype.Clone();

        Console.WriteLine("Cloned Values:");
        cloneedrouter.display();
        clonedswitch.display();

        // Update the names of the clones

        cloneedrouter.update("Router B");
        clonedswitch.update("Switch B");

        Console.WriteLine("Updated Cloned Values:");
        cloneedrouter.display();
        clonedswitch.display();

    }
}