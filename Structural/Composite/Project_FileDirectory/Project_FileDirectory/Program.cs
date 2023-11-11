using System;
using System.ComponentModel;

//Componenet

interface Component
{
    public void listContents();
    public int getSize();
}

//Leaf
class File : Component
{
    private string name;
    private int size;

    public File(string name, int size)
    {
        this.name = name;
        this.size = size;
    }
    public void listContents()
    {
        Console.WriteLine("File Name : " + name);
    }
    public int getSize()
    {
        return size;
    }
}

//Composite
class Directory : Component
{
    private string dirname;
    private List<Component> components;
    private int totsize = 0;

    public Directory(String dirname)
    {
        this.dirname = dirname;
        this.components = new List<Component>();
       
    }
    public void addComponent(Component comp)
    {
        components.Add(comp);
    }
    public void listContents()
    {
        Console.WriteLine("Directory Name:" + dirname);
        foreach (Component composite in components)
        {
            composite.listContents();            
        }
    }
    public int getSize()
    {
        foreach (Component composite in components)
        {
            totsize += composite.getSize();
        }
        return totsize;
    }
}
class main_client
{
    public static void Main(string[] args)
    {
        Component file1 = new File("file1.txt", 10);
        Component file2 = new File("file2.txt", 20);

        Directory root = new Directory("root");
        root.addComponent(file1);
        root.addComponent(file2);

        Directory subDir = new Directory("SubDir");

        Component file3 = new File("file3.txt", 30);
        subDir.addComponent(file3);

        root.addComponent(subDir);

        root.listContents();
        Console.WriteLine("Total Size of Directory:" + root + " is :" + root.getSize());

    }
}
    