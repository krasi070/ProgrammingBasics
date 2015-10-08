using System;

class CalculateDivisionBetweenFactorials
{
    static void Main()
    {
        Console.Write("Enter two positive integers(n > k):\nn = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        int factorialN = 1;
        int factorialK = 1;
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            if (i > k) 
            {
                continue;
            }
            factorialK *= i;
        }
        Console.WriteLine("n! / k! = {0}", factorialN / factorialK);
    }
}

