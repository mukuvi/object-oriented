using System;
/*
a class is a template for objects, and an object is an instance of a class
*/
class Brand{

    static void Benz(string name , int capital){
        Console.Write("Customer Name: ");
        string customer = Console.ReadLine();
        Console.WriteLine($"{customer} recently bought {name} at a price of {capital} M");
    }
    
    static int total(int x,int y){
        return x + y;
    }
    static void Main(){
        Console.WriteLine("Benz statements:");
        Benz("G wagon", 45);
        Benz("C class",9);
        Benz("S class", 15);
        Console.WriteLine(total(6,7));
        
    }
}