using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        a += 4;
        b += 1;
        Console.WriteLine(a + "\n" + b);
    }
}

