using System;

namespace ConsoleUI;

public class Motorcycle : Vehicle
{
    public override void DriveAbstract()
    {
        Console.WriteLine("Your motorcycle is driving abstractly!");
    }

    public override void DriveVirtual()
    {
        Console.WriteLine("Your motorcycle is driving Virtually!");
    }
}