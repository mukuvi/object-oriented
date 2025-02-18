/*
public:The code is accessible for all classes
private:The code is only accessible within the same class
protected:The code is accessible in a class that is inherited from that class.internal:	The code is only accessible within its own assembly, but not from another assembly.
*/
using System;

class Car{
    private string name = "Hilux";//private
    private string type = "pickup";//private
    static void Main(){
        Car Toyota = new Car();
        Console.WriteLine(Toyota.name);
    }
}