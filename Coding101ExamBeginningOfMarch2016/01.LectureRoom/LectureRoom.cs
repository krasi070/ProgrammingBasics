namespace _01.LectureRoom
{
    using System;

    public class LectureRoom
    {
        public static void Main()
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            int numberOfDesksOnRow = (int)((width * 100 - 100) / 70);
            int numberOfDesksOnCol = (int) ((height * 100) / 120);
            int desks = numberOfDesksOnCol * numberOfDesksOnRow - 3;

            Console.WriteLine(desks);
        }
    }
}
