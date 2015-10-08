using System;

class PointInsideCircleOutsideRectangle
{
    static void Main()
    {
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());
        bool isInTopCircle = (Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2) < 1.5 * 1.5);
        if (y <= 1)
        {
            isInTopCircle = false;
        }
        Console.WriteLine(isInTopCircle);
    }
}

