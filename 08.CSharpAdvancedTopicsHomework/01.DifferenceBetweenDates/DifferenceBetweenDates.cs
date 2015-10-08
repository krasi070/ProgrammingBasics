using System;

class DifferenceBetweenDates
{
    static void Main()
    {
        Console.Write("Enter first date (dd.MM.yyyy): ");
        DateTime fstDate = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter second date (dd.MM.yyyy): ");
        DateTime sndDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine((fstDate - sndDate).Days * -1);
    }
}

