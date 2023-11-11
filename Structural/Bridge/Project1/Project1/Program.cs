using System;

//Implemetation layer

interface NavigationImpl
{
    public void navigate();
}

//concrete implementation
class GoogleMaps : NavigationImpl
{
    public void navigate()
    {
        Console.WriteLine("Google Maps");
    }
}

class AppleMaps : NavigationImpl
{
    public void navigate()
    {
        Console.WriteLine("Apple Maps");
    }
}
//Abstraction layer

interface Uber
{
    public void navigatefor(string destination);
    public void setNavigation(NavigationImpl navigation);

}
//concrete Abstraction

class UberRide : Uber
{
    private string drivername;
    private NavigationImpl navigation;

    public UberRide(string drivername)
    {
        this.drivername = drivername;

    }
    public void setNavigation(NavigationImpl navigation)
    {
        this.navigation = navigation;
    }

    public void navigatefor(string destination)
    {
        Console.Write("Uber Riding with driver: " + drivername + " to " + destination + " using ");
        navigation.navigate();
    }

}
class UberEats : Uber
{
    private string restaurant;
    private NavigationImpl navigation;

    public UberEats(string restaurant)
    {
        this.restaurant = restaurant;

    }
    public void setNavigation(NavigationImpl navigation)
    {
        this.navigation = navigation;
    }

    public void navigatefor(string destination)
    {
        Console.Write("Uber Eats Order from Restaurant : " + restaurant + " to " + destination + " using ");
        navigation.navigate();
    }

}

class main_client
{
    public static void Main(string[] args)
    {
        Uber uberride = new UberRide("Swetha");

        Uber ubereats = new UberEats("Dominos");

        NavigationImpl google = new GoogleMaps();
        NavigationImpl apple = new AppleMaps();

        uberride.setNavigation(google);
        ubereats.setNavigation(apple);

        uberride.navigatefor("Seattle");
        ubereats.navigatefor("Redmond");
    }
}