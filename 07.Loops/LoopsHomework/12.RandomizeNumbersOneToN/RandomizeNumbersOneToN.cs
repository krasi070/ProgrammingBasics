using System;
using System.Linq;

class RandomizeNumbersOneToN
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Random random = new Random();
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            int randomNum = random.Next(1, n + 1);
            while(arr.Contains(randomNum))
            {
                randomNum = random.Next(1, n + 1);
            }
            arr[i] = randomNum;
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
}

