namespace _05.SaltAndPepper
{
    using System;
    using System.Linq;

    public class SaltAndPepper
    {
        public static void Main()
        {
            ulong dishes = ulong.Parse(Console.ReadLine());
            string[] dishesBinary = ConvertToUlongBinary(dishes).Select(b => b.ToString()).ToArray();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] args = command.Split();
                string spice = args[0];
                int step = int.Parse(args[1]);

                for (int i = 63; i >= 0; i -= step)
                {
                    if (spice == "salt" && dishesBinary[i] == "1")
                    {
                        dishesBinary[i] = "0";
                    }
                    else if (spice == "pepper" && dishesBinary[i] == "0")
                    {
                        dishesBinary[i] = "1";
                    }
                }

                command = Console.ReadLine();
            }

            ulong result = ConvertBinaryStringArrayToUlong(dishesBinary);
            Console.WriteLine(result);
        }

        private static string ConvertToUlongBinary(ulong number)
        {
            string binaryNumber = string.Empty;
            while (number != 0)
            {
                ulong bit = number % 2;
                number /= 2;
                binaryNumber = bit.ToString() + binaryNumber;
            }

            return binaryNumber.PadLeft(64, '0');
        }

        private static ulong ConvertBinaryStringArrayToUlong(string[] array)
        {
            ulong number = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] == "1")
                {
                    number += (ulong)Math.Pow(2, 63 - i);
                }
            }

            return number;
        }
    }
}
