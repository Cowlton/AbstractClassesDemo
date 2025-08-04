using System;

namespace ConsoleUI;

public class Car : Vehicle
{
    public override void DriveAbstract()
    {
        Console.WriteLine($"Your {Make} {Model} is driving abstractly!");
    }
}