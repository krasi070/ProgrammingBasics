using System;

class BeerTime
{
    static void Main()
    {
        Console.Write("Time(hh:mm tt): ");
        string time = Console.ReadLine();
        DateTime enteredTime = Convert.ToDateTime(time);
        string startTime = "13:00:00";
        DateTime startDateTime = Convert.ToDateTime(startTime);
        string endTime = "03:00:00";
        DateTime endDateTime = Convert.ToDateTime(endTime);
        if (enteredTime.TimeOfDay >= startDateTime.TimeOfDay)  
        {
            Console.WriteLine("Beer Time");
        }
        else if (enteredTime.TimeOfDay < endDateTime.TimeOfDay)
        {
            Console.WriteLine("Beer Time");
        }
        else
        {
            Console.WriteLine("Non-Beer Time");
        }
    }
}

