using System;

abstract class FoodItem
{
   public abstract string getDescription();
    public abstract double getPrice();
}

//concrete Classes

class Pizza : FoodItem
{
    public override string getDescription()
    {
        return "Pizza";
    }

    public override double getPrice()
    {
        return 200.00;
    }
}

class Burger : FoodItem
{
    public  override string getDescription()
    {
        return "Burger";
    }

    public override double getPrice()
    {
        return 100.00;
    }
}
//Decorator is-a foodItem
abstract class Decorator : FoodItem
{
    protected FoodItem food; // Decorator has-a FoodItem

    public Decorator(FoodItem food)
    {
        this.food = food;
    }
   
}

//concrete Decorators

class ExtraChesseDecorator : Decorator
{
    private double extracheeseprice;
    public ExtraChesseDecorator(FoodItem food, double Price) : base(food)
    {

        extracheeseprice = Price;
    }

    public override String getDescription()
    {
        return food.getDescription() + " With Extra Cheeese";
    }

    public override double getPrice()
    {
        return food.getPrice() + extracheeseprice;
    }
}

class ExtraSauceDecorator : Decorator
{
    private double extrasauceprice;
    public ExtraSauceDecorator(FoodItem food, double Price) : base(food)
    {

        extrasauceprice = Price;
    }

    public override String getDescription()
    {
        return food.getDescription() + " With Extra Sauce";
    }

    public override double getPrice()
    {
        return food.getPrice() + extrasauceprice;
    }
}

class ExtraToppingsDecorator : Decorator
{
    private double extratoppingsprice;
    public ExtraToppingsDecorator(FoodItem food, double Price) : base(food)
    {

        extratoppingsprice = Price;
    }

    public override String getDescription()
    {
        return food.getDescription() + " With Extra Toppings";
    }

    public override double getPrice()
    {
        return food.getPrice() + extratoppingsprice;
    }
}

class Main_client
{
    public static void Main(String[] args)
    {
        FoodItem pizzaorder = new Pizza();
        FoodItem burgerorder = new Burger();

        pizzaorder = new ExtraChesseDecorator(pizzaorder, 20.00);
        pizzaorder = new ExtraToppingsDecorator(pizzaorder, 30.00);

        Console.WriteLine("Pizza Order:" + pizzaorder.getDescription());
        Console.WriteLine("Price of Pizza Order :" + pizzaorder.getPrice());

        burgerorder = new ExtraSauceDecorator(burgerorder, 10.00);
        burgerorder = new ExtraChesseDecorator(burgerorder, 15.00);


        Console.WriteLine("Burger Order:" + burgerorder.getDescription());
        Console.WriteLine("Price of Burger Order :" + burgerorder.getPrice());
    }

}