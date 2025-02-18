using System;
/*
A constructor is a special method that is used to initialize objects. The advantage of a constructor, is that it is called when an object of a class is created. It can be used to set initial values for fields
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
