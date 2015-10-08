using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        double d = b * b - 4 * a * c;
        if (d > 0)
        {
            double x1 = (b * (-1) + Math.Sqrt(d)) / (a * 2);
            double x2 = (b * (-1) - Math.Sqrt(d)) / (a * 2);
            Console.WriteLine("x1 = {0}\nx2 = {1}", x1, x2);
        }
        else
        {
            if (d == 0) 
            {
                double x1 = (b * (-1) + Math.Sqrt(d)) / (a * 2);
                double x2 = (b * (-1) - Math.Sqrt(d)) / (a * 2);
                Console.WriteLine("x1 = x2 = {0}", x1);
            }
            else
            {
                Console.WriteLine("There are no real roots!");
            }
        }
    }
}

