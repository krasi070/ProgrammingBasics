﻿using System;

class PointInACircle
{
    static void Main()
    {
        Console.Write("x = ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        double y = double.Parse(Console.ReadLine());
        bool isInCircle = (Math.Pow(x, 2) + Math.Pow(y, 2) < 2 * 2);
        Console.WriteLine(isInCircle);
    }
}

