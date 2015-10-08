using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        long n = long.Parse(Console.ReadLine());
        long firstNum = 0;
        long secondNum = 1;
        long nextNum = 0;
        long[] arrayFib;
        arrayFib = new long[n];
        
        Console.Write("0 ");
        for (int i = 0; i < n - 1; i++)
        {
            firstNum = secondNum;
            secondNum = nextNum;
            nextNum = firstNum + secondNum;
            arrayFib[i] = nextNum;
            Console.Write(arrayFib[i] + " ");
        }
    }
}

