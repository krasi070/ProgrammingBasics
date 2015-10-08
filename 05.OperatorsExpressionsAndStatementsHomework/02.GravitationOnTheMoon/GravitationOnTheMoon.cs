using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("Weight: ");
        double weight = double.Parse(Console.ReadLine());
        double weightMoon = weight * 17 / 100;
        Console.WriteLine("Weight on the Moon: {0}", weightMoon);
    }
}

