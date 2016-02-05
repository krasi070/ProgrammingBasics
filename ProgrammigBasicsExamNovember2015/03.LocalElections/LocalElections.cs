namespace _03.LocalElections
{
    using System;

    class LocalElections
    {
        static void Main()
        {
            int candidates = int.Parse(Console.ReadLine());
            int chosenCandidate = int.Parse(Console.ReadLine());
            string choice = Console.ReadLine();

            for (int i = 1; i <= candidates; i++)
            {
                Console.WriteLine(".............");
                Console.WriteLine("...+-----+...");

                if (i == chosenCandidate && choice.ToLower() == "x")
                {
                    Console.WriteLine("...|.\\./.|...");
                    Console.WriteLine("{0}.|..X..|...", i.ToString().PadLeft(2, '0'));
                    Console.WriteLine("...|./.\\.|...");
                }
                else if (i == chosenCandidate && choice.ToLower() == "v")
                {
                    Console.WriteLine("...|\\.../|...");
                    Console.WriteLine("{0}.|.\\./.|...", i.ToString().PadLeft(2, '0'));
                    Console.WriteLine("...|..V..|...");
                }
                else
                {
                    Console.WriteLine("...|.....|...");
                    Console.WriteLine("{0}.|.....|...", i.ToString().PadLeft(2, '0'));
                    Console.WriteLine("...|.....|...");
                }

                Console.WriteLine("...+-----+...");
            }

            Console.WriteLine(".............");
        }
    }
}
