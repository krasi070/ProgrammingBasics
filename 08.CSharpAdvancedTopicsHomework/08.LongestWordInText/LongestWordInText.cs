using System;
using System.Collections.Generic;
using System.Linq;

class LongestWordInText
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string text = Console.ReadLine();
        int counter = text.Count(Char.IsWhiteSpace) + 1;
        List<string> textList = new List<string>();
        int curWord = 0;
        int longestWord = 0;
        string result = "";
        for (int i = 0; i < counter; i++)
        {
            textList.Add(text.Split(' ')[i]);
        }
        for (int i = 0; i < textList.Count; i++)
        {
            for (int j = 0; j < textList[i].Length; j++)
            {
                if ((textList[i][j] >= 65 && textList[i][j] <= 90) ^ (textList[i][j] >= 97 && textList[i][j] <= 122))
                {
                    curWord++;
                }
            }
            if (curWord > longestWord) 
            {
                result = textList[i];
                longestWord = curWord;
            }
            curWord = 0;
        }
        Console.Write("Longest word: ");
        for (int i = 0; i < result.Length; i++)
        {
            if ((result[i] >= 65 && result[i] <= 90) ^ (result[i] >= 97 && result[i] <= 122))
            {
                Console.Write(result[i]);
            }
        }
        Console.WriteLine();
    }
}

