namespace _01.ProspectInHospitality
{
    using System;

    class ProspectInHospitality
    {
        static void Main()
        {
            uint builders = uint.Parse(Console.ReadLine());
            uint receptionists = uint.Parse(Console.ReadLine());
            uint chambermaids = uint.Parse(Console.ReadLine());
            uint technicians = uint.Parse(Console.ReadLine());
            uint others = uint.Parse(Console.ReadLine());
            decimal nikisSalary = decimal.Parse(Console.ReadLine());
            decimal usaCurrencyRate = decimal.Parse(Console.ReadLine());
            decimal salary = decimal.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());

            decimal amount = (builders * 1500.04m) + (receptionists * 2102.10m) + (chambermaids * 1465.46m) +
                (technicians * 2053.33m) + (others * 3010.98m) + (nikisSalary * usaCurrencyRate) + salary;

            decimal leftOrNeeded = budget - amount;
            Console.WriteLine("The amount is: {0:F2} lv.", amount);

            if (leftOrNeeded < 0)
            {
                Console.WriteLine("NO \\ Need more: {0:F2} lv.", Math.Abs(leftOrNeeded));
            }
            else
	        {
                Console.WriteLine("YES \\ Left: {0:F2} lv.", Math.Abs(leftOrNeeded));
	        }
        }
    }
}
