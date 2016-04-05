namespace _01.VegetableMarket
{
    using System;

    public class VegetableMarket
    {
        public static void Main()
        {
            decimal vegetablePricePerKilo = decimal.Parse(Console.ReadLine());
            decimal fruitPricePerKilo = decimal.Parse(Console.ReadLine());
            decimal vegetableKilos = decimal.Parse(Console.ReadLine());
            decimal fruitKilos = decimal.Parse(Console.ReadLine());

            decimal priceInLeva = vegetablePricePerKilo*vegetableKilos + fruitPricePerKilo*fruitKilos;
            decimal priceInEuro = priceInLeva/1.94m;

            Console.WriteLine((double)priceInEuro);
        }
    }
}
