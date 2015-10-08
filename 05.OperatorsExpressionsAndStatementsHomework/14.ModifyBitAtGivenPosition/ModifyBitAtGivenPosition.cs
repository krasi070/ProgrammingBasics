using System;

class ModifyBitAtGivenPosition
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("v = ");
        int v = int.Parse(Console.ReadLine());
        int nTwo = n >> p;
        int mask = 1;
        int bitAtPositionP = (n & mask);
        if (bitAtPositionP == v)
        {
            Console.WriteLine(n);
        }
        else
        {
            v = 1;
            v = v << p;
            int result = (n ^ v);
            Console.WriteLine(result);
        }
    }
}

