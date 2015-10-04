using System;

class LongestAreaInArray
{
    static void Main()
    {
        //I wasn't sure if the problem wanted me to find the longest sequence 
        //or how many of the same string there are in the whole array so I did
        //it both ways. This program finds how many of the same string there are
        //in the array.
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        string[] arr = new string[n];
        int counter = 0;
        int temp = 0;
        string result = "";
        for (int i = 0; i < n; i++)
        {
            arr[i] = Console.ReadLine();
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (arr[i] == arr[j])
                {
                    counter++;
                }
            }
            if (counter > temp)
            {
                result = arr[i];
                temp = counter;
            }
            counter = 0;
        }
        Console.WriteLine(temp);
        for (int i = 0; i < temp; i++)
        {
            Console.WriteLine(result);
        }
    }
}

