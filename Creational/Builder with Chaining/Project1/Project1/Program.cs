using System;
using System.Data.Common;
using System.Runtime.CompilerServices;

class Desktop
{
    string motherboard;
    string processor;
    string memory;
    string storage;
    string grpahicscard;

   public void display()
    {
        Console.WriteLine("MotherBoard:" + motherboard);
        Console.WriteLine("processor:" + processor);
        Console.WriteLine("Memory:" + memory);
        Console.WriteLine("Storage:" + storage);
        Console.WriteLine("Grpahicscard:" + grpahicscard);
    }

    public void setmotherboard(string motherboard)
    {
        this.motherboard = motherboard;
    }
    public void setprocessor(string processor)
    {
        this.processor = processor;
    }
    public void setmemory(string memory)
    {
        this.memory = memory;
    }

    public void setstorage(string storage)
    {
        this.storage = storage;
    }
    public void setgraphicscard(string grpahicscard)
    {
        this.grpahicscard = grpahicscard;
    }
}
abstract class DesktopBuilder
{
    protected Desktop desktop;

    public abstract DesktopBuilder buildmotherboard();
    public abstract DesktopBuilder buildprocessor();
    public abstract DesktopBuilder buildmemory();
    public abstract DesktopBuilder buildstorage();
    public abstract DesktopBuilder buildgraphicscard();

    public Desktop getDesktop()
    {
        return desktop;
    }
}
class DellDesktopBuilder : DesktopBuilder
{

    public DellDesktopBuilder()
    {
        desktop = new Desktop();
    }
    public override DesktopBuilder buildmotherboard()
    {
        desktop.setmotherboard("Dell MotherBoard");
        return this;
    }
    public override DesktopBuilder buildprocessor()
    {
        desktop.setprocessor("Dell Processor");
        return this;
    }
    public override DesktopBuilder buildmemory()
    {
        desktop.setmemory("32GB DDR4 RAM");
        return this;
    }
    public override DesktopBuilder buildstorage()
    {
        desktop.setstorage("1TB SSD + 2TB HDD");
        return this;
    }
    public override DesktopBuilder buildgraphicscard()
    {
        desktop.setgraphicscard("NIVIDIA RTX 3080");
        return this;
    }

}

class HPDesktopBuilder : DesktopBuilder
{

    public HPDesktopBuilder()
    {
        desktop = new Desktop();
    }
    public override DesktopBuilder buildmotherboard()
    {
        desktop.setmotherboard("HP MotherBoard");
        return this;
    }
    public override DesktopBuilder buildprocessor()
    {
        desktop.setprocessor("HP Processor");
        return this;
    }
    public override DesktopBuilder buildmemory()
    {
        desktop.setmemory("16GB DDR4 RAM");
        return this;
    }
    public override DesktopBuilder buildstorage()
    {
        desktop.setstorage("512 SSD");
        return this;
    }
    public override DesktopBuilder buildgraphicscard()
    {
        desktop.setgraphicscard("Integrated Graphics");
        return this;
    }

}
class DesktopDirector
{
    //builder with chaining
    public Desktop buildDesktop(DesktopBuilder builder)
    {
        return builder.buildmotherboard().buildprocessor().buildmemory().buildstorage().buildgraphicscard().getDesktop();
    }
}
class DesktopDemo
{
    static void Main(string[] args)
    {
        DesktopDirector director = new DesktopDirector();

        DellDesktopBuilder dellbuilder = new DellDesktopBuilder();
        HPDesktopBuilder hpbuilder = new HPDesktopBuilder();

        Desktop dell = director.buildDesktop(dellbuilder);
        Desktop hp = director.buildDesktop(hpbuilder);

        dell.display();
        hp.display();

    }
}