using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.Write("Enter a decimal integer: ");
        long num = long.Parse(Console.ReadLine());
        long var = num;
        int counter = 0;
        string hexNum = "";

        if (num == 0) 
        {
            Console.Write(0);
        }

        while (var > 0) 
        {
            var /= 16;
            counter++;
        }
        string[] stringArr = new string[counter * 2];

        for (int i = 0; i < stringArr.Length; i++)
        {
            var = num % 16;
            num /= 16;
            stringArr[stringArr.Length - i - 1] = Convert.ToString(var);
            switch (stringArr[stringArr.Length - i - 1])
            {
                case "0":
                    stringArr[stringArr.Length - i - 1] = "";
                    break;
                case "10":
                    stringArr[stringArr.Length - i - 1] = "A";
                    break;
                case "11":
                    stringArr[stringArr.Length - i - 1] = "B";
                    break;
                case "12":
                    stringArr[stringArr.Length - i - 1] = "C";
                    break;
                case "13":
                    stringArr[stringArr.Length - i - 1] = "D";
                    break;
                case "14":
                    stringArr[stringArr.Length - i - 1] = "E";
                    break;
                case "15":
                    stringArr[stringArr.Length - i - 1] = "F";
                    break;
            }
        }

        for (int i = 0; i < stringArr.Length; i++)
        {
            hexNum += stringArr[i];
        }

        Console.WriteLine("{0}", hexNum);
    }
}

