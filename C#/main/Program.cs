﻿using System;

class Brand{

    static void Benz(string name, int capital){
        Console.Write("Customer Name: ");
        string customer = Console.ReadLine();
        Console.WriteLine($"{customer} recently bought {name} at a price of {capital} M");
    }
   
    static void Main(){
        Console.WriteLine("Benz statements:");
        Benz("G wagon", 45);
        Benz("C class",9);
        Benz("S class", 15);
    }
}