using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            Console.Write("Enter radius: ");
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI*radius;
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Perimeter is: {0:F2} ", perimeter);
            Console.WriteLine("Area is: {0:0.00}", area);
            
            
        }
    }
}
