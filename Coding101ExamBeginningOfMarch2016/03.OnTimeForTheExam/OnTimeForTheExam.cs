namespace _03.OnTimeForTheExam
{
    using System;

    public class OnTimeForTheExam
    {
        public static void Main()
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int examTime = examHour*60 + examMinutes;
            int arrivalTime = arrivalHour*60 + arrivalMinutes;
            int diff = arrivalTime - examTime;
            if (diff > 0)
            {
                Console.WriteLine("Late");
                if (diff < 60)
                {
                    Console.WriteLine("{0} minutes after the start", diff);
                }
                else
                {
                    int hours = diff / 60;
                    int minutes = diff%60;
                    string strMinutes = minutes < 10 ? "0" + minutes : minutes.ToString();
                    Console.WriteLine("{0}:{1} hours after the start", hours, strMinutes);
                }
            }
            else if (diff >= -30)
            {
                Console.WriteLine("On time");
                Console.WriteLine("{0} minutes before the start", Math.Abs(diff));
            }
            else
            {
                Console.WriteLine("Early");
                if (diff > -60)
                {
                    Console.WriteLine("{0} minutes before the start", Math.Abs(diff));
                }
                else
                {
                    int hours = Math.Abs(diff/60);
                    int minutes = Math.Abs(diff%60);
                    string strMinutes = minutes < 10 ? "0" + minutes : minutes.ToString();
                    Console.WriteLine("{0}:{1} hours before the start", hours, strMinutes);
                }
            }
        }
    }
}
