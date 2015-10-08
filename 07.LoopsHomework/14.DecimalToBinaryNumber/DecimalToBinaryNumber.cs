using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Enter a decimal integer: ");
        long intNum = long.Parse(Console.ReadLine());
        long empty = intNum;
        int counter = 0;
        string BinNum = "";

        if (intNum == 0) 
        {
            Console.Write(0);
        }

        while (empty > 0)
        {
            empty /= 2;
            counter++;
        }

        long[] arr = new long[counter];
        char[] charArr = new char[counter];

        for (int i = 0; i < counter; i++)
        {
            if (intNum > 0)
            {
                arr[i] = intNum % 2;
                intNum /= 2;
                charArr[counter - i - 1] = Convert.ToChar(arr[i]);
            }
        }

        for (int i = 0; i < counter; i++)
        {
            BinNum += Convert.ToString(charArr[i] + 0);
        }

        Console.WriteLine(BinNum);
    }
}

