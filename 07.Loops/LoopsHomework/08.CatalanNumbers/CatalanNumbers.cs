using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        BigInteger factorialTwoN = 1;
        BigInteger factorialNPlusOne = 1;
        for (int i = 1; i <= 2 * n; i++)
        {
            factorialTwoN *= i;
            if (i > n + 1) 
            {
                continue;
            }
            factorialNPlusOne *= i;
            if (i > n) 
            {
                continue;
            }
            factorial *= i;
        }
        Console.WriteLine(factorialTwoN / (factorialNPlusOne * factorial));
    }
}

