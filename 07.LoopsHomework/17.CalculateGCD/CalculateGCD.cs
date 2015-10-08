using System;

class CalculateGCD
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        int c = 0;
        int x = 0;
        int q = 0;

        if (a == 0 && b == 0)
        {
            Console.WriteLine("GCD: {0}", 0);
        }
        else if (a == 0)
	    {
            Console.WriteLine("GCD: {0}", b); 
	    }
        else if (b == 0)
        {
            Console.WriteLine("GCD: {0}", b);
        }
        else 
        {
            if (b > a) 
            {
                c = a;
                a = b;
                b = c;
            }

            do
            {
                x = a % b;
                if (x == 0)
                {
                    break;
                }
                q = a / b;
                c = b;
                b = x;
                a = c;
                x = a;
            } while (true);
            Console.WriteLine("GCD: {0}", b);
        }
    }
}

