using System;

class IlluminatiLock
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        Console.WriteLine("{0}{1}{0}",
            new string('.', size),
            new string('#', size),
            new string('.', size));

        int side = size;
        for (int i = 0; i < size / 2; i++)
        {
            side -= 2;

            Console.WriteLine("{0}{1}{2}{3}{4}{3}{2}{1}{0}",
                new string('.', side),
                "##",
                new string('.', i * 2),
                "#",
                new string('.', size - 2));
        }

        for (int i = size / 2 - 1; i >= 0; i--)
        {
            Console.WriteLine("{0}{1}{2}{3}{4}{3}{2}{1}{0}",
                new string('.', side),
                "##",
                new string('.', i * 2),
                "#",
                new string('.', size - 2));

            side += 2;
        }

        Console.WriteLine("{0}{1}{0}",
            new string('.', size),
            new string('#', size),
            new string('.', size));
    }
}

