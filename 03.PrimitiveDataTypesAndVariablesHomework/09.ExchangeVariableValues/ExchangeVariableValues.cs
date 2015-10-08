using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int c = a;
        Console.WriteLine("Before:\na={0}\nb={1}", a, b);
        a = b;
        b = c;
        Console.WriteLine("After:\na={0}\nb={1}", a, b);
    }
}
