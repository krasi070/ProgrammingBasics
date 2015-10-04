using System;

class CalculateProblemFive
{
    static void Main()
    {
        Console.Write("Entr two integers:\nn = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());
        int factorial = 1;
        double s = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            double partOfS = factorial / Math.Pow(x, i);
            s += partOfS;
        }
        Console.WriteLine("s = {0:F5}", s);
    }
}

