using System;

    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n , n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = j + 1 + i;
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            
        }
    }

