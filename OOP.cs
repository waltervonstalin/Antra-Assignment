using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


abstract class Department
{
    private string Name { get; set; }
    public Department(string name)
    {
        Name = name;
    }
    public abstract void position();
    public void displayname() {
        Console.WriteLine($"The person's name is {Name}.");
    }
}
class Manager : Department
{
    public Manager(string name):base(name) { }
    public override void position()
    {
        Console.WriteLine("The preson is the manager of this department.");
    }
}
class Employee : Department
{
    public Employee(string name) : base(name) { }
    public override void position()
    {
        Console.WriteLine("The person is the employee of this department.");
    }
}