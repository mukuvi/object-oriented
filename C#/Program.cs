using System;
//learn c#

/*
> I am currently learning c##
> I am using Girrafe academy course and W3Schools

*/
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      // DATA TYPES
        /*
        int myNum = 5;               // Integer (whole number)
        double myDoubleNum = 5.99D;  // Floating point number
        char myLetter = 'D';         // Character
        bool myBool = true;          // Boolean
        string myName = "Hello";     // String
        Console.WriteLine(myName +" "+ myNum  +" "+ myDoubleNum +" "+myLetter +" "+myBool  );
        */

        // USER  INPUT
        /*
        Console.Write("Enter Username: ");
        string username=Console.ReadLine();
        Console.Write("Enter your age: ");
        int age=Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Your username is " +username + " "+ " and your age is "+age);
        */

        //MATH
        /*
        Console.WriteLine( Math.Max(7,9)); // method can be used to find the highest value
        Console.WriteLine(Math.Min(5,4)); //method can be used to find the lowest value 
        Console.WriteLine(Math.Sqrt(36)); //method returns the square root
        Console.WriteLine(Math.Abs(-36)); // method returns the absolute (positive) value
        Console.WriteLine(Math.Round(6.78));  // rounds a number to the nearest whole number
        */
        // STRINGS
        /*
        string firstName = "James";
        string lastName = "Ngandu";
        string name = $"My full name is: {firstName} {lastName}";
        Console.WriteLine(name);
        */

        //IF ELSE
        int time = 20;
        string result = (time < 18) ? "Good day." : "Good evening.";
        Console.WriteLine(result);
    }
  }
}