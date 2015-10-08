using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        if (n < 1 || n > 100)
        {
            Console.WriteLine("Enter a positive integer from 1 to 100!");
        }
        else
        {
            bool prime = false;
            if (n == 1)
            {
                Console.WriteLine(prime);
            }
            else
            {
                int counter = 0;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        counter++;
                    }
                }
                prime = (counter == 0);
                Console.WriteLine(prime);
            }
        }
    }
}

