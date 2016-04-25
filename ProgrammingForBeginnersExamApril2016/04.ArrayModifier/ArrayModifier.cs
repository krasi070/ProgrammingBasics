namespace _04.ArrayModifier
{
    using System;
    using System.Linq;

    public class ArrayModifier
    {
        public static void Main()
        {
            long[] array = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] args = command.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                switch (args[0])
                {
                    case "swap":
                        Swap(array, long.Parse(args[1]), long.Parse(args[2]));
                        break;
                    case "multiply":
                        Multiply(array, long.Parse(args[1]), long.Parse(args[2]));
                        break;
                    case "decrease":
                        Decrease(array);
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", array));
        }

        private static void Swap(long[] arr, long firstIndex, long secondIndex)
        {
            long temp = arr[firstIndex];
            arr[firstIndex] = arr[secondIndex];
            arr[secondIndex] = temp;
        }

        private static void Multiply(long[] arr, long firstIndex, long secondIndex)
        {
            arr[firstIndex] *= arr[secondIndex];
        }

        private static void Decrease(long[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]--;
            }
        }
    }
}
