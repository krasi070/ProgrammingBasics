using System;
using System.Linq;

class HexadecimalToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter a hexadecimal integer: ");
        string hexNum = Console.ReadLine();
        string decHex = "";
        char[] charArr = hexNum.ToCharArray();
        string[] stringArr = new string[charArr.Length * 2];
        long[] arr = new long[charArr.Length];
        long decNum = 0;

        for (int i = 0; i < stringArr.Length; i++)
        {
            if (i % 2 == 0) 
            {
                stringArr[i] = Convert.ToString(charArr[i / 2]);
            }
            else
            {
                stringArr[i] = " ";
            }
            switch (stringArr[i])
            {
                case "A":
                    stringArr[i] = "10";
                    break;
                case "B":
                    stringArr[i] = "11";
                    break;
                case "C":
                    stringArr[i] = "12";
                    break;
                case "D":
                    stringArr[i] = "13";
                    break;
                case "E":
                    stringArr[i] = "14";
                    break;
                case "F":
                    stringArr[i] = "15";
                    break;
            }
            decHex += stringArr[i];
        }

        for (int i = 0; i < charArr.Length; i++)
        {
            arr[charArr.Length - i - 1] = long.Parse(decHex.Split(' ')[i]);
        }

        for (int i = 0; i < arr.Length; i++)
        {
            decNum += (long)(arr[i] * Math.Pow(16, i));
        }

        Console.WriteLine(decNum);
    }
}

