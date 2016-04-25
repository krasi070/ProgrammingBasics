namespace _02.GameOfNames
{
    using System;

    public class GameOfNames
    {
        public static void Main()
        {
            int numberOfEntries = int.Parse(Console.ReadLine());
            int highestScore = int.MinValue;
            string winnerName = string.Empty;

            for (int i = 0; i < numberOfEntries; i++)
            {
                string name = Console.ReadLine();
                int score = int.Parse(Console.ReadLine());
                for (int j = 0; j < name.Length; j++)
                {
                    if (name[j] % 2 == 0)
                    {
                        score += name[j];
                    }
                    else
                    {
                        score -= name[j];
                    }
                }

                if (highestScore < score)
                {
                    highestScore = score;
                    winnerName = name;
                }
            }

            Console.WriteLine("The winner is {0} - {1} points", winnerName, highestScore);
        }
    }
}
