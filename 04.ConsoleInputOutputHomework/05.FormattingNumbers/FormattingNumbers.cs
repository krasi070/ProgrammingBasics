using System;

class FormattingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        string aBinary = Convert.ToString(a, 2);
        Console.WriteLine("|{0,-10:X}|{1,10}|{2,10:0.00}|{3,-10:0.000}|", a, aBinary.PadLeft(10, '0'), b, c);
    }
}

