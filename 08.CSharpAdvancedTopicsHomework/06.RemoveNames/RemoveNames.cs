using System;
using System.Linq;
using System.Collections.Generic;

class RemoveNames
{
    static void Main()
    {
        Console.Write("First list: ");
        string fstNames = Console.ReadLine();
        int counter = fstNames.Count(Char.IsWhiteSpace) + 1;
        List<string> fstList = new List<string>();
        for (int i = 0; i < counter; i++)
        {
            fstList.Add(fstNames.Split(' ')[i]);
        }
        Console.Write("Second list: ");
        string sndNames = Console.ReadLine();
        int counter2 = sndNames.Count(Char.IsWhiteSpace) + 1;
        List<string> sndList = new List<string>();
        for (int i = 0; i < counter2; i++)
        {
            sndList.Add(sndNames.Split(' ')[i]);
        }
        for (int i = 0; i < fstList.Count; i++)
        {
            for (int j = 0; j < sndList.Count; j++)
            {
                if (fstList[i] == sndList[j]) 
                {
                    fstList.RemoveAt(i);
                    i--;
                    break;
                }
            }
        }
        foreach (var name in fstList)
        {
            Console.Write(name + " ");
        }
        Console.WriteLine();
    }
}

