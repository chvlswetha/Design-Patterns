using System;
using System.Runtime.CompilerServices;

abstract class ProductPrototype
{
    public abstract ProductPrototype clone();
    public abstract void display();

}

class Product : ProductPrototype
{
    private string name;
    private double price;

    public Product(string name, double price)
    {
        this.name = name;
        this.price = price;
    }

    
    public override ProductPrototype clone()
    {
        return new Product(name, price); // copying the constructor for cloning
    }
    public override void display()
    {
        Console.WriteLine("Product Name:" + name + ", Price: " + price);
    }
}
class ProductDemo
{
    static void Main(string[] args)
    {
        ProductPrototype laptop = new Product("Laptop", 666.66);
        ProductPrototype phone = new Product("SmartPhone", 999.99);

        Console.WriteLine("Original Products");

        laptop.display();
        phone.display();

        //cloned products


        ProductPrototype laptopclone = laptop.clone();
        ProductPrototype phoneclone = phone.clone();

        Console.WriteLine("Cloned Products");

        laptopclone.display();
        phoneclone.display();
    }
}