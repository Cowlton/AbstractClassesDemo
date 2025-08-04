using System;

namespace ConsoleUI;

public abstract class Vehicle
{
    public string Year = "2022";
    public string Make = "honda";
    public string Model = "civic";


    public abstract void DriveAbstract();
    
    public virtual void DriveVirtual()
    {
        Console.WriteLine($"You are driving your {Make} {Model} virtually!");
    }

}