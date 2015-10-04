using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Enter an unsigned integer: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());
        n = n >> p;
        uint mask = 1;
        uint result = (n & mask);
        Console.WriteLine("Bit #p: {0}", result);
    }
}

