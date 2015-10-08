using System;

class ExtractBitNumberThree
{
    static void Main()
    {
        Console.Write("Enter an unsigned integer: ");
        uint n = uint.Parse(Console.ReadLine());
        n = n >> 3;
        uint mask = 1;
        uint result = (n & mask);
        Console.WriteLine("Bit #3: {0}", result);
    }
}

