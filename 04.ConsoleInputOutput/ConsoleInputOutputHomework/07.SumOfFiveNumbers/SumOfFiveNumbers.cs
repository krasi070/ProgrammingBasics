using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Enter five numbers divided by a space: ");
        string fiveNums = Console.ReadLine();
        double a = Convert.ToDouble(fiveNums.Split(' ')[0]);
        double b = Convert.ToDouble(fiveNums.Split(' ')[1]);
        double c = Convert.ToDouble(fiveNums.Split(' ')[2]);
        double d = Convert.ToDouble(fiveNums.Split(' ')[3]);
        double e = Convert.ToDouble(fiveNums.Split(' ')[4]);
        Console.WriteLine("Sum: {0}", a + b + c + d + e); 
    }
}

