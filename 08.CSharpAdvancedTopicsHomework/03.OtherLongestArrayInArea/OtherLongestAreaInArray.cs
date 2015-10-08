using System;

class OtherLongestAreaInArray
{
    static void Main()
    {
        //This program finds the longest sequence.
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
                    if (counter > temp)
                    {
                        temp = counter;
                        result = arr[i];
                    }
                }
                else
                {
                    counter = 0;
                }
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

