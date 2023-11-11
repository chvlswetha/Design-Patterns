using System;

// All sub systems - CPU,Memory,GPU,DiskDrive, Network..
class CPU
{
    public void PowerOn()
    {
        Console.WriteLine("CPU is Powered ON");
    }
    public void ExcuteInstrictions()
    {
        Console.WriteLine("CPU is executing instructions");
    }
}
class Memory
{
    public void initialize()
    {
        Console.WriteLine("Memory is Initialized");
    }
}
class GPU
{
    public void enablegraphicscard()
    {
        Console.WriteLine("Grahics card is enabled");
    }
}
class DiskDrive
{
    public void BootfromDisk()
    {
        Console.WriteLine("Booting from Disk Drive");
    }
}
class Network
{
    public void connectNetwork()
    {
        Console.WriteLine("Connected to Network");
    }
}
//Facade class

class ComputerFacade
{
    private CPU cpu;
    private Memory memory;
    private GPU gpu;
    private DiskDrive diskDrive;
    private Network network;
    public ComputerFacade()
    {
        this.cpu = new CPU();
        this.memory = new Memory();
        this.gpu = new GPU();
        this.diskDrive = new DiskDrive();
        this.network = new Network();
    }
    public void StartComputer()
    {
        Console.WriteLine("starting Computer");
        cpu.PowerOn();
        memory.initialize();
        gpu.enablegraphicscard();
        diskDrive.BootfromDisk();
        network.connectNetwork();
        cpu.ExcuteInstrictions();

        Console.WriteLine("Computer Powered On and is ready to Use");
    }
}

class main_client
{
    public static void Main(string[] args)
    {
        ComputerFacade computer = new ComputerFacade();
        computer.StartComputer();
    }
}