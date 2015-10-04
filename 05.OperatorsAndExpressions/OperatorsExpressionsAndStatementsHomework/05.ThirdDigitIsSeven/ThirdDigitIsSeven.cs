using System;

class ThirdDigitIsSeven
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int thirdNum = (n % 1000) / 100;
        bool thirdNumSeven = (thirdNum == 7);
        Console.WriteLine(thirdNumSeven);
    }
}

