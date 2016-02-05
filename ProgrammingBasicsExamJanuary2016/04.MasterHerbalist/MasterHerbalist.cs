namespace _04.MasterHerbalist
{
    using System;

    class MasterHerbalist
    {
        static void Main()
        {
            int dailyExpenses = int.Parse(Console.ReadLine());
            int daysWorked = 0;
            int moneyEarnedThisSeason = 0;

            string args = Console.ReadLine();
            while (args != "Season Over")
            {
                daysWorked++;

                int time = int.Parse(args.Split()[0]);
                string path = args.Split()[1];
                int herbPrice = int.Parse(args.Split()[2]);

                int herbsCollected = 0; 
                int currHour = 0;
                while (currHour < time)
                {
                    string currPath = path[currHour % path.Length].ToString();
                    if (currPath == "H")
                    {
                        herbsCollected++;
                    }

                    currHour++;
                }

                int moneyEarnedToday = herbPrice * herbsCollected;
                moneyEarnedThisSeason += moneyEarnedToday;

                args = Console.ReadLine();
            }

            double averageDailyEarnings = 1.0 * moneyEarnedThisSeason / daysWorked;
            if (averageDailyEarnings >= dailyExpenses)
            {
                Console.WriteLine("Times are good. Extra money per day: {0:F2}.", averageDailyEarnings - dailyExpenses);
            }
            else
            {
                Console.WriteLine("We are in the red. Money needed: {0}.",
                    daysWorked * dailyExpenses - moneyEarnedThisSeason);
            }
        }
    }
}
