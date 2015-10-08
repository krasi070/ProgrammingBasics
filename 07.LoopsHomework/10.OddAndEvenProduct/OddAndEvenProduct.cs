using System;
using System.Linq;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("Enter N integrs divided by spaces: ");
        string nums = Console.ReadLine();
        int counter = nums.Count(Char.IsWhiteSpace);
        int[] arr = new int[counter + 1];
        int oddProduct = 0;
        int evenProduct = 0;
        for (int i = 0; i < counter + 1; i++)
        {
            arr[i] = int.Parse(nums.Split(' ')[i]);
            if ((i + 1) % 2 != 0) 
            {
                oddProduct += arr[i];
            }
            else
            {
                evenProduct += arr[i];
            }
        }
        if (oddProduct == evenProduct) 
        {
            Console.WriteLine("yes\nproduct = {0}", oddProduct);
        }
        else
	    {
            Console.WriteLine("no\nodd_product = {0}\neven_product = {1}", oddProduct, evenProduct);
	    }
    }
}

