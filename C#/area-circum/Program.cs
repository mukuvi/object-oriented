using System;

class Circle
{
        private double radius;

    public Circle(double r)
    {
        radius = r;
    }

    public double ComputeArea()
    {
        return Math.PI * radius * radius;
    }

    public double ComputeCircumference()
    {
        return 2 * Math.PI * radius;
    }
}

class Program
{
    static void Main()
    {
        // Input radius
        Console.Write("Enter the radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());

        // Create Circle object
        Circle circle = new Circle(radius);

        Console.WriteLine($"Area of the circle: {circle.ComputeArea():F2}");
        Console.WriteLine($"Circumference of the circle: {circle.ComputeCircumference():F2}");
    }
}