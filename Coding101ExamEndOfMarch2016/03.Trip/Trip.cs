namespace _03.Trip
{
    using System;

    public class Trip
    {
        public static void Main()
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = string.Empty;
            string place = string.Empty;
            decimal price = 0m;
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {    
                    place = "Camp";
                    price = budget*0.3m;
                }
                else
                {
                    place = "Hotel";
                    price = 0.7m*budget;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    place = "Camp";
                    price = budget*0.4m;
                }
                else
                {
                    place = "Hotel";
                    price = budget*0.8m;
                }
            }
            else
            {
                destination = "Europe";
                place = "Hotel";
                price = budget*0.9m;
            }

            Console.WriteLine("Somewhere in {0}\n{1} - {2:F2}", destination, place, price);
        }
    }
}
