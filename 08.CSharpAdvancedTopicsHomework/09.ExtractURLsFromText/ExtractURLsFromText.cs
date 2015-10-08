using System;
using System.Collections.Generic;
using System.Linq;

class ExtractURLsFromText
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();
        int counter = text.Count(Char.IsWhiteSpace) + 1;
        List<string> textList = new List<string>();
        for (int i = 0; i < counter; i++)
        {
            textList.Add(text.Split(' ')[i]);
        }
        for (int i = 0; i < textList.Count; i++)
        {
            if ((textList[i][0] == 'w' && textList[i][1] == 'w' && textList[i][2] == 'w' && textList[i][3] == '.') ^
                (textList[i][0] == 'h' && textList[i][1] == 't' && textList[i][2] == 't' && textList[i][3] == 'p' && textList[i][4] == ':' && textList[i][5] == '/' && textList[i][6] == '/'))
            {
                for (int j = 0; j < textList[i].Length; j++)
                {
                    if (!(!(textList[i][j] >= 'a' && textList[i][j] <= 'z') && j == textList[i].Length - 1)) 
                    {
                        Console.Write(textList[i][j]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

