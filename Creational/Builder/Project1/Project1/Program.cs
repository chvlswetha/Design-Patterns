using System;
using System.Data.Common;
using System.Runtime.CompilerServices;

class Desktop
{
    private string motherboard;
    private string processor;
    private string memory;
    private string storage;
    private string grpahicscard;

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

    public string getmotherboard()
    {
        return motherboard;
    }
    public string getprocessor()
    {
        return processor;
    }
    public string getmemory()
    {
        return memory;
    }
    public string getstorage()
    {
        return storage;
    }
    public string getgraphicscard()
    {
        return grpahicscard;
    }
}
abstract class DesktopBuilder
{
    protected Desktop desktop = new Desktop();

    public abstract void buildmotherboard();
    public abstract void buildprocessor();
    public abstract void buildmemory();
    public abstract void buildstorage();
    public abstract void buildgraphicscard();

    public Desktop getDesktop()
    {
        return desktop;
    }
}
class DellDesktopBuilder : DesktopBuilder
{
    public override void buildmotherboard()
    {
        desktop.setmotherboard("Dell MotherBoard");
    }
    public override void buildprocessor()
    {
        desktop.setprocessor("Dell Processor");
    }
    public override void buildmemory()
    {
        desktop.setmemory("32GB DDR4 RAM");
    }
    public override void buildstorage()
    {
        desktop.setstorage("1TB SSD + 2TB HDD");
    }
    public override void buildgraphicscard()
    {
        desktop.setgraphicscard("NIVIDIA RTX 3080");
    }

}

class HPDesktopBuilder : DesktopBuilder
{
    public override void buildmotherboard()
    {
        desktop.setmotherboard("HP MotherBoard");
    }
    public override void buildprocessor()
    {
        desktop.setprocessor("HP Processor");
    }
    public override void buildmemory()
    {
        desktop.setmemory("16GB DDR4 RAM");
    }
    public override void buildstorage()
    {
        desktop.setstorage("512GB SSD");
    }
    public override void buildgraphicscard()
    {
        desktop.setgraphicscard("Integrated Graphics");
    }

}
class DesktopDirector
{
    public Desktop buildDesktop(DesktopBuilder builder)
    {
        builder.buildmotherboard();
        builder.buildprocessor();
        builder.buildmemory();
        builder.buildstorage();
        builder.buildgraphicscard();
        return builder.getDesktop();
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