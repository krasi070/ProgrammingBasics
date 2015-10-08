using System;

class PrintASCIITable
{
    static void Main()
    {
        for (char i = '\u0000'; i <= '\u00FF'; i++)
        {
            Console.Write(i + " ");
        }
    }
}
