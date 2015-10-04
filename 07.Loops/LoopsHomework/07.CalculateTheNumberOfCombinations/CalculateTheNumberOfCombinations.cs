using System;
using System.Numerics;

class CalculateTheNumberOfCombinations
{
    static void Main()
    {
        Console.Write("Enter two positive integers(n > k):\nn = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialNMinusK = 1;
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            if (i > k)
            {
                continue;
            }
            factorialK *= i;
        }
        for (int i = 1; i <= n - k; i++)
        {
            factorialNMinusK *= i;
        }
        Console.WriteLine("n! / (k! * (n - k)!) = {0}", factorialN / (factorialK * factorialNMinusK));
    }
}

