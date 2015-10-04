using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter a four digit number: ");
        int num = int.Parse(Console.ReadLine());
        int a = num / 1000;
        int b = (num % 1000) / 100;
        int c = (num % 100) / 10;
        int d = num % 10;
        Console.WriteLine("Sum: {0}", a + b + c + d);
        Console.WriteLine("Reversed: {0}", d * 1000 + c * 100 + b * 10 + a);
        Console.WriteLine("Last digit in front: {0}", d * 1000 + a * 100 + b * 10 + c);
        Console.WriteLine("Second and third digits exchanged: {0}", a * 1000 + c * 100 + b * 10 + d);
    }
}

