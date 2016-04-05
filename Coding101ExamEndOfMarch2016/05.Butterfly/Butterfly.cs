﻿namespace _05.Butterfly
{
    using System;

    public class Butterfly
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i < size - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}\\ /{0}", new string('*', size - 2));
                }
                else
                {
                    Console.WriteLine("{0}\\ /{0}", new string('-', size - 2));
                }
            }

            Console.WriteLine("{0}@{0}", new string(' ', size - 1));
            for (int i = 0; i < size - 2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}/ \\{0}", new string('*', size - 2));
                }
                else
                {
                    Console.WriteLine("{0}/ \\{0}", new string('-', size - 2));
                }
            }
        }
    }
}
