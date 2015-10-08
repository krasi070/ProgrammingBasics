using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        bool odd = (n % 2 == 1);
        Console.WriteLine(odd);
    }
}

