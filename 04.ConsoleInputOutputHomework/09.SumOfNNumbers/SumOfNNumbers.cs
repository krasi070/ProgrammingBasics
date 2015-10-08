using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        double enteredNums = 0;
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            enteredNums = double.Parse(Console.ReadLine());
            sum += enteredNums;
        }
        Console.WriteLine(sum);
    }
}

