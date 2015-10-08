using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type: \n1 --> int\n2 --> double\n3 --> string");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            Console.Write("Please enter an integer: ");
            int integer = int.Parse(Console.ReadLine());
            Console.WriteLine(integer + 1);
        }
        else if (choice == 2)
        {
            Console.Write("Please enter a double: ");
            double enteredDouble = double.Parse(Console.ReadLine());
            Console.WriteLine(enteredDouble + 1);
        }
        else if (choice == 3) 
        {
            Console.Write("Please enter a string: ");
            string enteredString = Console.ReadLine();
            Console.WriteLine(enteredString + "*");
        }
        else
        {
            Console.WriteLine("Please enter 1, 2 or 3.");
        }
    }
}

