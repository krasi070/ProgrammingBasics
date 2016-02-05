namespace _02.BeerStock
{
    using System;

    class BeerStock
    {
        static void Main()
        {
            long reservedBeers = long.Parse(Console.ReadLine());
            long recievedBeers = 0;

            string shipment = Console.ReadLine();
            while (shipment != "Exam Over")
            {
                long amount = long.Parse(shipment.Split()[0]);
                string type = shipment.Split()[1];

                if (type.Equals("beers"))
                {
                    recievedBeers += amount;
                }
                else if (type.Equals("sixpacks"))
                {
                    recievedBeers += amount * 6;
                }
                else if (type.Equals("cases"))
                {
                    recievedBeers += amount * 24;
                }

                shipment = Console.ReadLine();
            }

            recievedBeers -= (recievedBeers / 100);

            if (recievedBeers >= reservedBeers)
            {
                long allLeftBeers = recievedBeers - reservedBeers;
                long leftCases = allLeftBeers / 24;
                long leftSixpacks = (allLeftBeers % 24) / 6;
                long leftBeers = (allLeftBeers % 24) % 6;

                Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", 
                    leftCases, leftSixpacks, leftBeers);
            }
            else
            {
                long allNeededBeers = reservedBeers - recievedBeers;
                long neededCases = allNeededBeers / 24;
                long neededSixpacks = (allNeededBeers % 24) / 6;
                long neededBeers = (allNeededBeers % 24) % 6;

                Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.",
                    neededCases, neededSixpacks, neededBeers);
            }
        }
    }
}
