using System;

class ZeroSubset
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("d = ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("e = ");
        int e = int.Parse(Console.ReadLine());
        bool isTrue = true;
        if (a + b == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, b);
            isTrue = false;
        }
        if (a + c == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, c);
            isTrue = false;
        }
        if (a + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, d);
            isTrue = false;
        }
        if (a + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", a, e);
            isTrue = false;
        }
        if (b + c == 0)
        {
            Console.WriteLine("{0} + {1} = 0", c, b);
            isTrue = false;
        }
        if (d + b == 0)
        {
            Console.WriteLine("{0} + {1} = 0", d, b);
            isTrue = false;
        }
        if (e + b == 0)
        {
            Console.WriteLine("{0} + {1} = 0", e, b);
            isTrue = false;
        }
        if (c + d == 0)
        {
            Console.WriteLine("{0} + {1} = 0", c, d);
            isTrue = false;
        }
        if (c + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", c, e);
            isTrue = false;
        }
        if (d + e == 0)
        {
            Console.WriteLine("{0} + {1} = 0", d, e);
            isTrue = false;
        }
        if (a + b + c == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, c);
            isTrue = false;
        }
        if (a + b + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, d);
            isTrue = false;
        }
        if (a + b + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, b, e);
            isTrue = false;
        }
        if (a + d + c == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, d, c);
            isTrue = false;
        }
        if (a + e + c == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, e, c);
            isTrue = false;
        }
        if (a + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", a, d, e);
            isTrue = false;
        }
        if (d + b + c == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", d, b, c);
            isTrue = false;
        }
        if (e + b + c == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", e, b, c);
            isTrue = false;
        }
        if (d + e + c == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", d, e, c);
            isTrue = false;
        }
        if (d + b + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} = 0", d, b, e);
            isTrue = false;
        }
        if (a + b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, d);
            isTrue = false;
        }
        if (a + b + c + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, c, e);
            isTrue = false;
        }
        if (a + e + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, e, c, d);
            isTrue = false;
        }
        if (e + b + c + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", e, b, c, d);
            isTrue = false;
        }
        if (a + b + e + d == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} = 0", a, b, e, d);
            isTrue = false;
        }
        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", a, b, c, d, e);
            isTrue = false;
        }
        if (isTrue)
        {
            Console.WriteLine("no zero subset");
        }
    }
}

