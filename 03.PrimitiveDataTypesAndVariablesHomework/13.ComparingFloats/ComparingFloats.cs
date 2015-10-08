using System;

class ComparingFloats
{
    static void Main()
    {
        Console.Write("a = ");
        string stringA = Console.ReadLine();
        double a = Convert.ToDouble(stringA);
        Console.Write("b = ");
        string stringB = Console.ReadLine();
        double b = Convert.ToDouble(stringB);
        double eps = 0.000001;
        double difference = Math.Abs(a - b);
        if (eps > difference)
        {
            bool equal = true;
            Console.WriteLine(equal);
        }
        else
        {
            bool equal = (a == b);
            Console.WriteLine(equal);
        }
    }
}
