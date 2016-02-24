namespace _04.PassionDays
{
    using System;

    public class PassionDays
    {
        public static void Main()
        {
            decimal money = decimal.Parse(Console.ReadLine());
            long numberOfPurchases = 0;
            string command = Console.ReadLine();
            command = Console.ReadLine();

            while (command != "mall.Exit")
            {
                for (int i = 0; i < command.Length; i++)
                {
                    if (command[i] >= 'A' && command[i] <= 'Z')
                    {
                        if (money - command[i] / 2m >= 0)
                        {
                            money -= command[i] / 2m;
                            numberOfPurchases++;
                        }
                    }
                    else if (command[i] >= 'a' && command[i] <= 'z')
                    {
                        if (money - command[i] * 3m / 10m >= 0)
                        {
                            money -= command[i] * 3m / 10m;
                            numberOfPurchases++;
                        }
                    }
                    else if (command[i] == '%')
                    {
                        if (money != 0)
                        {
                            money /= 2m;
                            numberOfPurchases++;
                        }
                    }
                    else if (command[i] == '*')
                    {
                        money += 10;
                    }
                    else
                    {
                        if (money - command[i] >= 0)
                        {
                            money -= command[i];
                            numberOfPurchases++;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            if (numberOfPurchases > 0)
            {
                Console.WriteLine("{0} purchases. Money left: {1:F2} lv.", numberOfPurchases, money);
            }
            else
            {
                Console.WriteLine("No purchases. Money left: {0:F2} lv.", money);
            }
        }
    }
}
