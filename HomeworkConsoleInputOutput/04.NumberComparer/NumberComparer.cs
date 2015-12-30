using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            double max = Math.Max(firstNumber, secondNumber);
            Console.WriteLine("The greater number is: {0}", max);
        }
    }
}
