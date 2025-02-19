/*
> Polymorphism occurs when many classes are related to each other by inheritance.
*/

using System;

class Car  // Base class (parent)
{
    public virtual void Drive()
    {
        Console.WriteLine("The car is driving.");
    }
}

class Toyota : Car  // Derived class (child)
{
    public override void Drive()
    {
        Console.WriteLine("The Toyota is driving smoothly.");
    }
}

class Ford : Car  // Derived class (child)
{
    public override void Drive()
    {
        Console.WriteLine("The Ford is driving powerfully.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car();          // Base class object
        Car myToyota = new Toyota();    // Derived class object
        Car myFord = new Ford();        // Derived class object

        myCar.Drive();      // Calls the base class method
        myToyota.Drive();   // Calls the overridden method in Toyota
        myFord.Drive();     // Calls the overridden method in Ford
    }
}
