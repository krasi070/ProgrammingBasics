using System;

class QuotesInStrings
{
    static void Main()
    {
        string firstType = @"The ""use"" of quotations causes difficulties.";
        string secondType = "The \"use\" of quotations causes difficulties.";
        Console.WriteLine(firstType + "\n" + secondType);
    }
}

