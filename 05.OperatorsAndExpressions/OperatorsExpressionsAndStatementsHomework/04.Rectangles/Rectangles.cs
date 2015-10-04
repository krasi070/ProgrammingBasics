using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Height: ");
        double height = double.Parse(Console.ReadLine());
        double perimeter = 2 * (width + height);
        double area = width * height;
        Console.WriteLine("Perimeter: {0}\nArea: {1}", perimeter, area);
    }
}

