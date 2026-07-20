
using System;

class Area
{
    public double CalculateArea(double radius)
    {
        return 3.14 * radius * radius;
    }
    public double CalculateArea(double length, double width)
    {
        return length * width;
    }
    public double CalculateArea(double b, double h, int triangle)
    {
        return 0.5 * b * h;
    }
}

class Program
{
    static void Main()
    {
        Area obj = new Area();

        Console.Write("Enter Radius of Circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Area of Circle = " + obj.CalculateArea(radius));

        Console.Write("\nEnter Length of Rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Width of Rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Area of Rectangle = " + obj.CalculateArea(length, width));

        Console.Write("\nEnter Base of Triangle: ");
        double baseValue = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Height of Triangle: ");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Area of Triangle = " + obj.CalculateArea(baseValue, height, 1));
    }
}