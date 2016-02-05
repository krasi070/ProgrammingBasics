namespace _01.CakeTycoon
{
    using System;

    class CakeTycoon
    {
        static void Main()
        {
            ulong wantedCakes = ulong.Parse(Console.ReadLine());
            decimal flourNeededForCake = decimal.Parse(Console.ReadLine());
            uint flourAvailable = uint.Parse(Console.ReadLine());
            uint trufflesAvailable = uint.Parse(Console.ReadLine());
            uint trufflePrice = uint.Parse(Console.ReadLine());

            decimal amountOfMakableCakes = flourAvailable / flourNeededForCake;
            amountOfMakableCakes = Math.Floor(amountOfMakableCakes);

            decimal  costToMakeCakes = (decimal)trufflePrice * trufflesAvailable;
            decimal cakePrice = (costToMakeCakes / wantedCakes) * 1.25m;

            if (amountOfMakableCakes >= wantedCakes)
            {
                Console.WriteLine("All products available, price of a cake: {0:F2}", cakePrice);
            }
            else
            {
                decimal neededFlourForAllCakes = wantedCakes * flourNeededForCake;
                decimal neededFlour = neededFlourForAllCakes - flourAvailable;

                Console.WriteLine("Can make only {0} cakes, need {1:F2} kg more flour",
                    amountOfMakableCakes,
                    neededFlour);
            }
        }
    }
}
