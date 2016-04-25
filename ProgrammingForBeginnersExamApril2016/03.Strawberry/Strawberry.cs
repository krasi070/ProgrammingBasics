namespace _03.Strawberry
{
    using System;

    public class Strawberry
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            for (int i = 0; i < size / 2; i++)
            {
                Console.WriteLine(
                    "{0}\\{1}|{1}/{0}",
                    new string('-', i * 2),
                    new string('-', size - i * 2));
            }

            int outside = size;
            int inside = 1;
            for (int i = 0; i < size / 2 + 2; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('-', outside), new string('.', inside));
                outside -= 2;
                if (outside < 0)
                {
                    outside = 0;
                    inside += 2;
                }
                else
                {
                    inside += 4;
                }
            }

            inside -= 2;
            for (int i = 0; i < size; i++)
            {
                outside++;
                inside -= 2;
                Console.WriteLine("{0}#{1}#{0}", new string('-', outside), new string('.', inside));
            }
        }
    }
}
