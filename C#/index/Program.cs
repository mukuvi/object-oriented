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
       
        /*
        int money = 2000;
        string capital =(money>5000)?"well payed":"Poorly payed";
        Console.WriteLine(capital);
        */

        //SWITCH
        /*
        int day=2;
        switch(day){
          case 1:
          Console.WriteLine("Monday");
          break;
          case 2:
          Console.WriteLine("Tuesday");
          break;
          default:
          Console.WriteLine("Does not exist");
          break;
        }
        */

        //WHILE LOOP  
        /*
        int position =0;
        while(position<5){
          Console.WriteLine(position);
          position++;
        }
          
        //DO WHILE
        do{
          Console.WriteLine(position);
          position++;
        }while(position<3);
        
      
      //FOR LOOP
      for(int i=0; i<5;i++){
        Console.WriteLine(i);
      }
     
      //FOR EACH
      string[] students=["james","julia","john"];
      foreach(string stud in students){
        Console.WriteLine(stud);
      }
       */

      //BREAK //CONTINUE
      /*
      for(int i=0;1<10;i++){
        if(i==5){
          break;
        }
        Console.WriteLine(i);
      }

      for (int j=0;j<10;j++){
        if(j==5){
          continue;
        }Console.WriteLine(j);
      }
      */

      //ARRAYS
      /*
      int[] num =[1,2,3,4,5];
      string[] days={"Monday","Tuesday","Wednesday","Thursday","Friday"};
      Array.Sort(days);//sorting an array
      Console.WriteLine(num.Length);//length of an array
      for(int day =0; day<days.Length;day++){
        Console.WriteLine($"Today is on {days[day]}");
      }

      int[,] numbers ={{1,2,3},{5,6,7}};//Two-Dimensional Arrays[,]
      Console.WriteLine(numbers[1,1]);//row and column [1,1]
      foreach(int i in numbers)
          {
            Console.WriteLine(i);
          };
      */

      Console.WriteLine("KEEP CODING, KEEP MOVING, KEEP PUSHING");

    }
  }
}