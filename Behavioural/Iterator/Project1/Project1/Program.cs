using System;

class Product
{
    string name;
    double price;

    public Product(string name, double price)
    {
        this.name = name;   
        this.price = price; 
    }

    public string getName()
    {
        return name;
    }
    public double getPrice()
    {
        return price;
    }
}

interface Iterator
{
    public Product first();
    public Product next();

    public bool hasNext();
}

class concreateclass : Iterator
{
    private List<Product> products;

    private int current;

    public concreateclass(List<Product> products)
    {
        this.products = products;
        this.current = 0;
    }
    public Product first()
    {
        current = 0;
        return products[current];
    }

    public Product next()
    {
        if (hasNext())
            return products[++current];
        else
            return null;
    }

    public bool hasNext()
    {
        if (products.Count - 1 > current)
            return true;
        else
            return false;

    }
}
class Inventory
{
    List<Product> products = new List<Product>();

    public void addProdcut(Product product)
    {
        products.Add(product);
    }
    public Iterator CreateIterator()
    {
        return new concreateclass(products);
    }
}

class Main_client
{
    public static void Main(string[] args)
    {
        Product prod1 = new Product("Laptop", 500.00);
        Product prod2 = new Product("Phone", 200.00);
        Product prod3 = new Product("HeadPhone", 100.00);

        Inventory inventory = new Inventory();
        inventory.addProdcut(prod1);
        inventory.addProdcut(prod2);
        inventory.addProdcut(prod3);

        Iterator it = inventory.CreateIterator();

        Product one = it.first();

        while(one != null)
        {
            Console.WriteLine("The Product is:" + one.getName() + ": and Price is: " + one.getPrice());
            one = it.next();
        }
    }
}