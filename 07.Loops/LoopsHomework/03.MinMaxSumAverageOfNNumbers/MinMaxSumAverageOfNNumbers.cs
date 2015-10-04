using System;

class MinMaxSumAverageOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int n = int.Parse(Console.ReadLine());
        double[] nums = new double[n];
        double sum = 0;
        double max = 0;
        double min = 0;
        for (int i = 0; i < n; i++)
        {
            nums[i] = double.Parse(Console.ReadLine());
            sum += nums[i];
            if (i == 0) 
            {
                continue;
            }
            max = Math.Max(nums[i - 1], nums[i]);
            min = Math.Min(nums[i - 1], nums[i]);
        }
        double average = sum / n;
        Console.WriteLine("min = {0:0.##}\nmax = {1:0.##}\nsum = {2:0.##}\navg = {3:0.##}",min, max, sum, average);
    }
}

