using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("r = ");
        double r = double.Parse(Console.ReadLine());
        double perimeter = 2 * r * Math.PI;
        double area = r * r * Math.PI;
        Console.WriteLine("Perimeter: {0:0.00}\nArea: {1:0.00}", perimeter, area);
    }
}

