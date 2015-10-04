using System;
using System.Collections.Generic;
using System.Linq;

class JoinLists
{
    static void Main()
    {
        Console.Write("First list: ");
        string fstNums = Console.ReadLine();
        int counter = fstNums.Count(Char.IsWhiteSpace) + 1;
        List<string> fstList = new List<string>();
        for (int i = 0; i < counter; i++)
        {
            fstList.Add(fstNums.Split(' ')[i]);
        }
        Console.Write("Second list: ");
        string sndNums = Console.ReadLine();
        int counter2 = sndNums.Count(Char.IsWhiteSpace) + 1;
        List<string> sndList = new List<string>();
        for (int i = 0; i < counter2; i++)
        {
            sndList.Add(sndNums.Split(' ')[i]);
        }
        fstList.AddRange(sndList);
        fstList.Sort();
        for (int i = 0; i < fstList.Count; i++)
        {
            for (int j = 0; j < fstList.Count; j++)
            {
                if (fstList[i] == fstList[j] && i != j) 
                {
                    fstList.RemoveAt(j);
                    i--;
                    break;
                }
            }
        }
        foreach (var number in fstList)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}

