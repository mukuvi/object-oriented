using System;

class Program
{
    static void Main()
    {
        int[] marks = new int[100];
        int sum = 0;

        // Input marks for 100 students
        for (int i = 0; i < 100; i++)
        {
            Console.Write($"Enter mark for student {i + 1}: ");
            marks[i] = int.Parse(Console.ReadLine());
            sum += marks[i];
        }

        // Compute mean
        double mean = (double)sum / 100;
        Console.WriteLine($"The mean mark of the class is: {mean}");
    }
}