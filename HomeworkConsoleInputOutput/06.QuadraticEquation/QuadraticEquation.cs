using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            double thirdNumber = double.Parse(Console.ReadLine());
            double d = Math.Pow(secondNumber, 2) - 4 * firstNumber * thirdNumber;

            if (d < 0)
            {
                Console.WriteLine("no real roots");
            }
            else
            {
                double firstRoot = (-secondNumber + Math.Sqrt(d)) / (2*firstNumber);
                double secondRoot = (-secondNumber - Math.Sqrt(d)) / (2*firstNumber);               
                if (d == 0)
                {
                    Console.WriteLine("x1 = x2 = {0} ", firstRoot);
                }
                else 
                {
                    Console.WriteLine("x1 = {0}; x2 = {1} ", firstRoot, secondRoot);
                }
                
                
            }
            
        }
    }
}
