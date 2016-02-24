namespace _01.HungryGarfield
{
    using System;

    public class HungryGarfield
    {
        public static void Main()
        {
            decimal givenMoney = decimal.Parse(Console.ReadLine());
            decimal dollarExchangeRate = decimal.Parse(Console.ReadLine());
            decimal pizzaPrice = decimal.Parse(Console.ReadLine());
            decimal lasagnaPrice = decimal.Parse(Console.ReadLine());
            decimal sandwichPrice = decimal.Parse(Console.ReadLine());
            ulong pizzaQuantity = ulong.Parse(Console.ReadLine());
            ulong lasagnaQuantity = ulong.Parse(Console.ReadLine());
            ulong sandwichQuantity = ulong.Parse(Console.ReadLine());

            decimal moneyNeeded =
                (pizzaPrice / dollarExchangeRate * pizzaQuantity) +
                (lasagnaPrice / dollarExchangeRate * lasagnaQuantity) +
                (sandwichPrice / dollarExchangeRate * sandwichQuantity);
            if (givenMoney >= moneyNeeded)
            {
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:F2}.", givenMoney - moneyNeeded);
            }
            else
            {
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:F2}.", moneyNeeded - givenMoney);
            }
        }
    }
}
