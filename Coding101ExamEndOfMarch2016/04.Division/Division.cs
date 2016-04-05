namespace _04.Division
{
    using System;

    public class Division
    {
        public static void Main()
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());
            int numbersDivideableBy2Count = 0;
            int numbersDivideableBy3Count = 0;
            int numbersDivideableBy4Count = 0;
            for (int i = 0; i < numberOfNumbers; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());
                if (currNumber % 2 == 0)
                {
                    numbersDivideableBy2Count++;
                }

                if (currNumber % 3 == 0)
                {
                    numbersDivideableBy3Count++;
                }

                if (currNumber % 4 == 0)
                {
                    numbersDivideableBy4Count++;
                }
            }

            decimal percentOfNumbersDividableBy2 = 100m * numbersDivideableBy2Count/numberOfNumbers;
            decimal percentOfNumbersDividableBy3 = 100m * numbersDivideableBy3Count/numberOfNumbers;
            decimal percentOfNumbersDividableBy4 = 100m * numbersDivideableBy4Count/numberOfNumbers;
            Console.WriteLine(
                "{0:F2}%\n{1:F2}%\n{2:F2}%",
                percentOfNumbersDividableBy2,
                percentOfNumbersDividableBy3,
                percentOfNumbersDividableBy4);
        }
    }
}
