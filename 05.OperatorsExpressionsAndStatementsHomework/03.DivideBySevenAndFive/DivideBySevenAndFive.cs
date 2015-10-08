using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        bool divideSevenFive = (n % 5 == 0 && n % 7 == 0);
        Console.WriteLine(divideSevenFive);
    }
}

