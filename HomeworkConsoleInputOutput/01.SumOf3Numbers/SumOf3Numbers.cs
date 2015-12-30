using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SumOf3Numbers
{
    class SumOf3Numbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("Enter a second number: ");
            double b = int.Parse(Console.ReadLine());
            Console.Write("Enter a third number: " );
            double c = int.Parse(Console.ReadLine());
            Console.WriteLine(a + b + c);
        }
    }
}
