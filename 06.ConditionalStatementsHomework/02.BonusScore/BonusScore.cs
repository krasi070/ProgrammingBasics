﻿using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Input score[1...9]: ");
        int score = int.Parse(Console.ReadLine());
        if (score >= 1 && score <= 3)
        {
            Console.WriteLine(score * 10);
        }
        else if (score >= 4 && score <= 6)
        {
            Console.WriteLine(score * 100);
        }
        else if (score >= 7 && score <= 9) 
        {
            Console.WriteLine(score * 1000);
        }
        else
        {
            Console.WriteLine("Invalid score");
        }
    }
}

