using System;

class PrintDeckOfCards
{
    static void Main()
    {
        for (int i = 2; i <= 10; i++)
        {
            Console.WriteLine(i + "\u2663" + " " + i + "\u2666" + " " + i + "\u2665" + " " + i + "\u2660");
        }
        Console.WriteLine("J\u2663 J\u2666 J\u2665 J\u2660\nQ\u2663 Q\u2666 Q\u2665 Q\u2660\nK\u2663 K\u2666 K\u2665 K\u2660\nA\u2663 A\u2666 A\u2665 A\u2660");
    }
}

