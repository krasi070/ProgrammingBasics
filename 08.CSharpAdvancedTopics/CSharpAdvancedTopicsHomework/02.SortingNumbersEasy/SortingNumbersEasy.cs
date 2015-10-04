using System;

class SortingNumbersEasy
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(arr);
        for (int j = 0; j < n; j++)
        {
            Console.Write(arr[j] + " ");
        }
        Console.WriteLine();
    }
}

