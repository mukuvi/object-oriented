/*
The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users.
> provide public get and set methods, through properties, to access and update the value of a private field
> The get method returns the value of the variable 
> The set method assigns a value to the variable
*/
using System;

class Person{
    private string name;
    public string Name{
        get{return name;}
        set{name =value;}
    }
}
class Program{
    static void Main(){
        Person myName =new Person();
        myName.Name="James Mukuvi";
        Console.WriteLine(myName.Name);
    }
}