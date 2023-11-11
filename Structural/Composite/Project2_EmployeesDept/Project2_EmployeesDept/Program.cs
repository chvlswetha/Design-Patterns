using System;

//Component

interface EmployeeComponent
{
    public void displayinfo();
    public double calculatesalary();
}

//Leaf

class Employee : EmployeeComponent
{
    private string name;
    private double salary;

    public Employee(string name, double salary)
    {
        this.name = name;   
        this.salary = salary;   
    }
    public void displayinfo()
    {
        Console.WriteLine("Employee Name: " + name + ", Salary:" + salary);
    }
    public double calculatesalary()
    {
        return salary;
    }
}

//Composite # 1

class Team : EmployeeComponent
{
    private string team;
    private double totsalary = 0;
    private List<EmployeeComponent> components;

    public Team(string team)
    {
        this.team = team;
        this.components = new List<EmployeeComponent>();
    }
    public void addmember(EmployeeComponent component )
    {
        components.Add( component );
    }
    public void displayinfo()
    {
        Console.WriteLine("Team Name:" + team);
        foreach(EmployeeComponent component in components )
        {
            component.displayinfo();           
        }
    }

    public double calculatesalary()
    {
       
        foreach (EmployeeComponent component in components)
        {
            totsalary += component.calculatesalary();
            
        }
        return totsalary;
    }
}

//composite 2
class Department : EmployeeComponent
{
    private string dept;
    private double totsalary;
    private List<EmployeeComponent> components;

    public Department(string dept)
    {
        this.dept = dept;
        this.components = new List<EmployeeComponent>();
    }
    public void addmember(EmployeeComponent component)
    {
        components.Add(component);
    }
    public void displayinfo()
    {
        Console.WriteLine("Department Name:" + dept);
        foreach (EmployeeComponent component in components)
        {
            component.displayinfo();
        }
    }

    public double calculatesalary()
    {

        foreach (EmployeeComponent component in components)
        {
            totsalary += component.calculatesalary();

        }
        return totsalary;
    }
}

class main_client
{
    public static void Main(string[] args)
    {
        EmployeeComponent swetha = new Employee("Swetha", 300);
        EmployeeComponent kames = new Employee("Kames", 400);

        Team team1 = new Team("Parents");

        team1.addmember(swetha);
        team1.addmember(kames);

        EmployeeComponent Aachu = new Employee("Aachu", 150);
        EmployeeComponent Ammu = new Employee("Ammu", 150);


        Team team2 = new Team("Kids");

        team2.addmember(Aachu);
        team2.addmember(Ammu);

        Department home = new Department("Sweet Home");
        home.addmember(team1);
        home.addmember(team2);

        home.displayinfo();
        double totsalary = home.calculatesalary() ;
        Console.WriteLine("Total Salary is:" + totsalary);
       
    }
}