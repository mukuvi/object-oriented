using System;

class Rectangle
{
  
    private double length;
    private double width;

    public Rectangle(double l, double w)
    {
        length = l;
        width = w;
    }

    public double ComputeArea()
    {
        return length * width;
    }

    // Method to compute perimeter
    public double ComputePerimeter()
    {
        return 2 * (length + width);
    }
}

class Program
{
    static void Main()
    {
        // Input length and width
        Console.Write("Enter the length of the rectangle: ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("Enter the width of the rectangle: ");
        double width = double.Parse(Console.ReadLine());

        // Create Rectangle object
        Rectangle rectangle = new Rectangle(length, width);

        Console.WriteLine($"Area of the rectangle: {rectangle.ComputeArea():F2}");
        Console.WriteLine($"Perimeter of the rectangle: {rectangle.ComputePerimeter():F2}");
    }
}