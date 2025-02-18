using System;
/*
>Object-Oriented Programming
>a class is a template for objects, and an object is an instance of a class
*/
class Car
{
  string brand = "Toyota";
  static void Main(string[] args)
  {
    Car myObj1 = new Car();
    Car myObj2 = new Car();
    Console.WriteLine(myObj1.brand);
  
  }
}