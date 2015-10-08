using System;

class AgeAfter10Years
{
    static void Main()
    {
        string birthday = Console.ReadLine();
        DateTime bday = Convert.ToDateTime(birthday);
        DateTime today = DateTime.Today;
        TimeSpan dif = today.Subtract(bday);
        int daysold = (int)dif.TotalDays;
        double exactyears = daysold / 365.2425;
        double years = Math.Floor(exactyears);
        Console.Write("Now:");
        Console.WriteLine(years);
        double plusten = years + 10;
        Console.Write("After 10 years:");
        Console.WriteLine(plusten);
    }
}

