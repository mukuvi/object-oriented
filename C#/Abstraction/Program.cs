/*
> abstraction is the process of hiding certain details and showing only essential information to the user
*/
using System;

abstract class Car
{
    // Abstract method (does not have a body)
    public abstract void Drive();
    
    public void Stop()
    {
        Console.WriteLine("The car has stopped.");
    }
}

// Derived class (inherit from Car)
class Toyota : Car
{
    public override void Drive()
    {
        Console.WriteLine("The Toyota car is driving smoothly.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Toyota myToyota = new Toyota(); // Create a Toyota object
        myToyota.Drive();  // Call the abstract method
        myToyota.Stop();   // Call the regular method
    }
}
