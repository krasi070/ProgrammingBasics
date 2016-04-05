namespace _02.TransportPrice
{
    using System;

    public class TransportPrice
    {
        public static void Main()
        {
            int kilometers = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            if (kilometers < 20)
            {
                double taxiPrice = time == "day" ? (0.7 + kilometers * 0.79) : (0.7 + kilometers * 0.9);
                Console.WriteLine(taxiPrice);
            }
            else if (kilometers < 100)
            {
                double busPrice = kilometers * 0.09;
                Console.WriteLine(busPrice);
            }
            else
            {
                double trainPrice = kilometers * 0.06;
                Console.WriteLine(trainPrice);
            }
        }
    }
}
