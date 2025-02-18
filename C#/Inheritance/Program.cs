/*
>Inheritance (Derived and Base Class)
> Derived Class (child) - the class that inherits from another class
> Base Class (parent) - the class being inherited from
*/

class Vehicle  // base class (parent) 
{
  public string brand = "Toyota";  // Vehicle field
  public void Model()             // Vehicle method 
  {                    
    Console.WriteLine("Toyota hilux");
  }
}

class Car : Vehicle  // derived class (child)
{
  public string modelName = "Land Cruser"; 
}

class Program
{
  static void Main(string[] args)
  {
        Car myCar = new Car();
        myCar.Model();
        Console.WriteLine(myCar.brand + " " + myCar.modelName);
  }
}
