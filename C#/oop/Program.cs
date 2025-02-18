using System;
/*
>Object-Oriented Programming
>a class is a template for objects, and an object is an instance of a class

>A constructor is a special method that is used to initialize objects. The advantage of a constructor, is that it is called when an object of a class is created. It can be used to set initial values for fields

>Access Modifiers - public:The code is accessible for all classes
                    private:The code is only accessible within the same class
                    protected:The code is accessible in a class that is inherited from that class.internal:	The code is only accessible within its own assembly, but not from another assembly.
*/
class Car {
    public string brand;
    public string model;
    public int year;

    public Car(string carBrand, string carModel, int carYear)//constructor
    {
        brand = carBrand;
        model = carModel;
        year= carYear;
    }

    static void Main(){
        Car myCar = new Car("Toyota","Hilux",2025);

        Console.WriteLine($"I bought {myCar.brand} {myCar.model } {myCar.year}");
    }
}
