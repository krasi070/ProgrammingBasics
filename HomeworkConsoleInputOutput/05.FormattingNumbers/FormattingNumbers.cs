using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            double thirdNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("|{0,-10:X}|{1}|{2,10:0.##}|{3,-10:0.000}|",
                firstNumber, Convert.ToString(firstNumber, 2).PadLeft(10, '0') , secondNumber, thirdNumber);

        }
    }
}
