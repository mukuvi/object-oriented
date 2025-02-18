/*
> Polymorphism occurs when many classes are related to each other by inheritance.
*/

using System;
class Animal  // Base class (parent) 
{
  public virtual void animalSound() 
  {
    Console.WriteLine("The animal makes a sound");
  }
}

class Pig : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The pig says: wee wee");
  }
}

class Dog : Animal  // Derived class (child) 
{
  public override void animalSound() 
  {
    Console.WriteLine("The dog says: bow wow");
  }
}

class Program 
{
  static void Main(string[] args) 
  {
    Animal myAnimal = new Animal();  
    Animal myPig = new Pig();
    Animal myDog = new Dog();

    myAnimal.animalSound();
    myPig.animalSound();
    myDog.animalSound();
  }
}