namespace _04.Histogram
{
    using System;

    public class Histogram
    {
        public static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int under200 = 0;
            int under400 = 0;
            int under600 = 0;
            int under800 = 0;
            int under1000 = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());
                if (currNumber < 200)
                {
                    under200++;
                }
                else if (currNumber < 400)
                {
                    under400++;
                }
                else if (currNumber < 600)
                {
                    under600++;
                }
                else if (currNumber < 800)
                {
                    under800++;
                }
                else
                {
                    under1000++;
                }
            }

            double under200Percent = 1.0 * under200/numberOfLines*100;
            Console.WriteLine("{0:F2}%", under200Percent);
            double under400Percent = 1.0 * under400 / numberOfLines * 100;
            Console.WriteLine("{0:F2}%", under400Percent);
            double under600Percent = 1.0 * under600 / numberOfLines * 100;
            Console.WriteLine("{0:F2}%", under600Percent);
            double under800Percent = 1.0 * under800 / numberOfLines * 100;
            Console.WriteLine("{0:F2}%", under800Percent);
            double under1000Percent = 1.0 * under1000 / numberOfLines * 100;
            Console.WriteLine("{0:F2}%", under1000Percent);
        }
    }
}
