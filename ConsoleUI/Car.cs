using System;

namespace ConsoleUI;

public class Car : Vehicle
{
    
    public bool HasTrunk { get; set; }
    
    public int MaxSpeed { get; set; }
    
    public override void DriveAbstract()
    {
        Console.WriteLine($"Your {Make} {Model} is driving abstractly!");
    }
}