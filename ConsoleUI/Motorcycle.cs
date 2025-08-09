using System;

namespace ConsoleUI;

public class Motorcycle : Vehicle
{
    
    public bool HasSideCar { get; set; }

    public bool IsSafe = false;

    public override void DriveAbstract()
    {
        Console.WriteLine("Your motorcycle is driving abstractly!");
    }

    public override void DriveVirtual()
    {
        Console.WriteLine("Your motorcycle is driving Virtually!");
    }
}