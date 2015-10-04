using System;

class NumberAsWords
{
    static void Main()
    {
        Console.Write("Enter a number[0...999]: ");
        int num = int.Parse(Console.ReadLine());
        int a = num / 100;
        int b = (num / 10) % 10;
        int c = num % 10;
        int bPlusC = b * 10 + c;
        if (num == 0)
        {
            Console.WriteLine("zero");
        }
        else if (num > 0 && num < 1000) 
        {
            if (a == 1)
            {
                Console.Write("one hundred and ");
            }
            else if (a == 2) 
	        {
                Console.Write("two hundred and ");
	        }
            else if (a == 3)
            {
                Console.Write("three hundred and ");
            }
            else if (a == 4)
            {
                Console.Write("four hundred and ");
            }
            else if (a == 5)
            {
                Console.Write("five hundred and ");
            }
            else if (a == 7)
            {
                Console.Write("seven hundred and "); 
            }
            else if (a == 8)
            {
                Console.Write("eight hundred and ");
            }
            else if (a == 9)
            {
                Console.Write("nine hundred and ");
            }
            if (b == 1) 
            {
                if (bPlusC == 10)
                {
                    Console.WriteLine("ten");
                }
                else if (bPlusC == 11)
                {
                    Console.WriteLine("eleven");
                }
                else if (bPlusC == 12)
                {
                    Console.WriteLine("twelve");
                }
                else if (bPlusC == 13)
                {
                    Console.WriteLine("thirteen");
                }
                else if (bPlusC == 14)
                {
                    Console.WriteLine("fourteen");
                }
                else if (bPlusC == 15)
                {
                    Console.WriteLine("fifteen");
                }
                else if (bPlusC == 16)
                {
                    Console.WriteLine("sixteen");
                }
                else if (bPlusC == 17)
                {
                    Console.WriteLine("seventeen");
                }
                else if (bPlusC == 18)
                {
                    Console.WriteLine("eighteen");
                }
                else if (bPlusC == 19)
                {
                    Console.WriteLine("nineteen");
                }
            }
            else
            {
                if (b == 2)
                {
                    Console.Write("twenty ");
                }
                else if (b == 3)
                {
                    Console.Write("thirty ");
                }
                else if (b == 4)
                {
                    Console.Write("forty ");
                }
                else if (b == 5)
                {
                    Console.Write("fifty ");
                }
                else if (b == 6)
                {
                    Console.Write("sixty ");
                }
                else if (b == 7)
                {
                    Console.Write("seventy ");
                }
                else if (b == 8)
                {
                    Console.Write("eighty ");
                }
                else if (b == 9)
                {
                    Console.Write("ninety ");
                }
                if (c == 0)
                {
                    Console.WriteLine();
                }
                else if (c == 1)
                {
                    Console.WriteLine("one");
                }
                else if (c == 2)
                {
                    Console.WriteLine("two");
                }
                else if (c == 3)
                {
                    Console.WriteLine("three");
                }
                else if (c == 4)
                {
                    Console.WriteLine("four");
                }
                else if (c == 5)
                {
                    Console.WriteLine("five");
                }
                else if (c == 6)
                {
                    Console.WriteLine("six");
                }
                else if (c == 7)
                {
                    Console.WriteLine("seven");
                }
                else if (c == 8)
                {
                    Console.WriteLine("eight");
                }
                else if (c == 9)
                {
                    Console.WriteLine("nine");
                }
            }
        }
        else
        {
            Console.WriteLine("Please enter a number from 0 to 999.");
        }
    }
}

