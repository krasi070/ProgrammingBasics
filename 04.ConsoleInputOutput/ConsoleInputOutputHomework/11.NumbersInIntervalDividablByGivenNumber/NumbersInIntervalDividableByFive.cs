using System;

class NumbersInIntervalDividableByFive
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int b = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = a; i <= b; i++)
        {
            if (i % 5 == 0)
                counter++;
        }
            Console.WriteLine(counter);
    }
}

