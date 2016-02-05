namespace _02.SudokuResults
{
    using System;

    class SudokuResults
    {
        static void Main()
        {
            int countGames = 0;
            int totalTimeInSeconds = 0;

            string line = Console.ReadLine();
            while (line != "Quit")
            {
                countGames++;

                int minutes = int.Parse(line.Split(':')[0]);
                int seconds = int.Parse(line.Split(':')[1]);
                totalTimeInSeconds += minutes * 60 + seconds;

                line = Console.ReadLine();
            }

            decimal averageTimeInSeconds = 1m * totalTimeInSeconds / countGames;

            if (averageTimeInSeconds <= 720)
            {
                Console.WriteLine("Gold Star");
            }
            else if (averageTimeInSeconds <= 1440)
            {
                Console.WriteLine("Silver Star");
            }
            else
            {
                Console.WriteLine("Bronze Star");
            }

            Console.WriteLine("Games - {0} \\ Average seconds - {1}",
                countGames, Math.Ceiling(averageTimeInSeconds));
        }
    }
}
