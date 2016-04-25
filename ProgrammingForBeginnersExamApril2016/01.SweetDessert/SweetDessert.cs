namespace _01.SweetDessert
{
    using System;

    public class SweetDessert
    {
        public static void Main()
        {
            decimal money = decimal.Parse(Console.ReadLine());
            int numberOfGuests = int.Parse(Console.ReadLine());
            decimal bananaPrice = decimal.Parse(Console.ReadLine());
            decimal eggPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPricePerKilo = decimal.Parse(Console.ReadLine());

            int portions = numberOfGuests;
            while (portions % 6 != 0)
            {
                portions++;
            }

            int neededBananas = (portions/6)*2;
            int neededEggs = (portions/6)*4;
            decimal neededKilosOfBerries = (portions/6)*0.2m;
            decimal priceForEverything =
                (neededBananas*bananaPrice) +
                (neededEggs*eggPrice) +
                (berriesPricePerKilo*neededKilosOfBerries);

            if (money >= priceForEverything)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:F2}lv.", priceForEverything);
            }
            else
            {
                Console.WriteLine(
                    "Ivancho will have to withdraw money - he will need {0:F2}lv more.", 
                    priceForEverything - money);
            }
        }
    }
}
