﻿using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("h = ");
        double h = double.Parse(Console.ReadLine());
        double area = (a + b) * h / 2;
        Console.WriteLine("Area: {0}", area);
    }
}

