using System;
using System.Linq;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter a binary integer: ");
        string binaryNum = Console.ReadLine();
        char[] charArr = binaryNum.ToCharArray();
        int[] arr = new int[charArr.Length];
        long decInt = 0;

        for (int i = 0; i < charArr.Length; i++)
        {
            arr[charArr.Length - i - 1] = Convert.ToInt32(charArr[i]) - 48;
        }

        for (int i = 0; i < charArr.Length; i++)
        {
            decInt = (long)(decInt + arr[i] * Math.Pow(2, i));
        }

        Console.WriteLine(decInt);
    }
}

