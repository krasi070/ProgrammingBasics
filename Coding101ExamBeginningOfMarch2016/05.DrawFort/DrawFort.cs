namespace _05.DrawFort
{
    using System;

    public class DrawFort
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine(
                "/{0}\\{1}/{0}\\", 
                new string('^', size / 2),
                new string('_', size * 2 - (4 + 2 * (size / 2))));

            for (int i = 0; i < size - 2; i++)
            {
                if (i != size - 3)
                {
                    Console.WriteLine("|{0}|", new string(' ', 2 * size - 2));
                }
                else
                {
                    Console.WriteLine(
                        "|{0}{1}{0}|",
                        new string(' ', 1 + size / 2), 
                        new string('_', size * 2 - (4 + 2 * (size / 2))));
                }
            }

            Console.WriteLine(
                "\\{0}/{1}\\{0}/",
                new string('_', size / 2),
                new string(' ', size * 2 - (4 + 2 * (size / 2))));
        }
    }
}
