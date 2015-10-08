using System;
using System.Numerics;
using System.Linq;

class TrailingZeroesInN
{
    static void Main()
    {
        Console.Write("n = ");
        long n = long.Parse(Console.ReadLine());
        BigInteger counter = 0;
        for (BigInteger i = 5; i <= n; i *= 5) 
        {
            counter += (n / i);
        }
        Console.WriteLine(counter);
    }
}

