namespace _04.PerfectGirlfriend
{
    using System;

    class PerfectGirlfriend
    {
        static void Main()
        {
            int perfectGirls = 0;
            string line = Console.ReadLine();

            while (line != "Enough dates!")
            {
                string dayOfWeek = line.Split('\\')[0];
                string number = line.Split('\\')[1];
                string braSize = line.Split('\\')[2];
                string name = line.Split('\\')[3];

                int numberOfWeek = GetNumberFromDayOfWeek(dayOfWeek);
                int sumOfTelephoneNumberDigits = GetSumOfTelephoneNumberDigits(number);
                int braSizeNumber = GetBraSizeNumber(braSize);
                int nameNumber = GetNameNumber(name);

                int result = numberOfWeek + sumOfTelephoneNumberDigits + braSizeNumber - nameNumber;

                if (result < 6000)
                {
                    Console.WriteLine("Keep searching, {0} is not for you.", name);
                }
                else
                {
                    Console.WriteLine("{0} is perfect for you.", name);
                    perfectGirls++;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(perfectGirls);
        }

        private static int GetNumberFromDayOfWeek(string dayOfWeek)
        {
            switch (dayOfWeek)
            {
                case "Monday":
                    return 1;
                case "Tuesday":
                    return 2;
                case "Wednesday":
                    return 3;
                case "Thursday":
                    return 4;
                case "Friday":
                    return 5;
                case "Saturday":
                    return 6;
                case "Sunday":
                    return 7;
                default:
                    return -1;
            }
        }

        private static int GetSumOfTelephoneNumberDigits(string number)
        {
            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                sum += int.Parse(number[i].ToString());
            }

            return sum;
        }

        private static int GetBraSizeNumber(string braSize)
        {
            return int.Parse(braSize.Substring(0, braSize.Length - 1)) * braSize[braSize.Length - 1];
        }

        private static int GetNameNumber(string name)
        {
            return name[0] * name.Length;
        }
    }
}
