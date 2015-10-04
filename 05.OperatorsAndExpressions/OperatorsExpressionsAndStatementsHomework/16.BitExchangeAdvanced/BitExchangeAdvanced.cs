using System;


class BitExchangeAdvanced
{
    static void Main()
    {
        Console.Write("n = ");
        uint n = uint.Parse(Console.ReadLine());
        Console.Write("p = ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("q = ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());
        int counter = 0;
        if ((p + k - 1) > 31 || (q + k - 1) > 31 || p < 0 || q < 0)
        {
            Console.WriteLine("Out of range!");
        }
        else
        {
            for (int i = p; i <= (p + k - 1); i++)
            {
                for (int r = q; r <= (q + k - 1); r++)
                {
                    if (i == r)
                    {
                        counter++;
                    }
                }
            }
            if (counter > 0)
            {
                Console.WriteLine("Overlapping!");
            }
            else
            {
                Console.WriteLine("Binary n: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
                uint firstPart = n >> p;
                firstPart = firstPart << (32 - k);
                firstPart = firstPart >> ((32 - k) - p);
                uint secondPart = n >> q;
                secondPart = secondPart << (32 - k);
                secondPart = secondPart >> (32 - k - q);
                uint mask = firstPart ^ secondPart;
                uint result = mask ^ n;
                firstPart = firstPart >> p;
                firstPart = firstPart << (32 - k);
                firstPart = firstPart >> ((32 - k) - q);
                secondPart = secondPart >> q;
                secondPart = secondPart << (32 - k);
                secondPart = secondPart >> (32 - k - p);
                mask = firstPart ^ secondPart;
                result = mask ^ result;
                Console.WriteLine("Binary result: {0}", Convert.ToString(result, 2).PadLeft(32, '0'));
                Console.WriteLine("Result: {0}", result);
            }
        } 
    }
}

