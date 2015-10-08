using System;

class BitsExchange
{
    static void Main()
    {
        Console.Write("Enter an unsigned integer: ");
        uint n = uint.Parse(Console.ReadLine());
        Console.WriteLine("Binary number: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));

        uint firstThreeBits = n >> 3;
        firstThreeBits = firstThreeBits << 29;
        firstThreeBits = firstThreeBits >> 26;

        uint secondThreeBits = n << 5;
        secondThreeBits = secondThreeBits >> 29;
        secondThreeBits = secondThreeBits << 24;

        uint mask = firstThreeBits ^ secondThreeBits;
        uint result = n ^ mask;
        firstThreeBits = firstThreeBits << 21;
        result = result ^ firstThreeBits;
        secondThreeBits = secondThreeBits >> 21;
        result = result ^ secondThreeBits;

        Console.WriteLine("Binary result: {0}", Convert.ToString(result, 2).PadLeft(32, '0'));
        Console.WriteLine("Result: {0}", result);
    }
}

