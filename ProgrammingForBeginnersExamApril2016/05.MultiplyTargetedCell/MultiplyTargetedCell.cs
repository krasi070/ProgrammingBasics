namespace _05.MultiplyTargetedCell
{
    using System;
    using System.Linq;

    public class MultiplyTargetedCell
    {
        public static void Main()
        {
            string[] dimensions = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);
            long[,] matrix = new long[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                long[] currRow = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(long.Parse)
                    .ToArray();

                for (int j = 0; j < currRow.Length; j++)
                {
                    matrix[i, j] = currRow[j];
                }
            }

            string[] target = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int targetRow = int.Parse(target[0]);
            int targetCol = int.Parse(target[1]);

            long sum = matrix[targetRow - 1, targetCol - 1] +
                       matrix[targetRow - 1, targetCol] +
                       matrix[targetRow - 1, targetCol + 1] +
                       matrix[targetRow, targetCol - 1] +
                       matrix[targetRow, targetCol + 1] +
                       matrix[targetRow + 1, targetCol - 1] +
                       matrix[targetRow + 1, targetCol] +
                       matrix[targetRow + 1, targetCol + 1];

            matrix[targetRow - 1, targetCol - 1] *= matrix[targetRow, targetCol];
            matrix[targetRow - 1, targetCol] *= matrix[targetRow, targetCol];
            matrix[targetRow - 1, targetCol + 1] *= matrix[targetRow, targetCol];
            matrix[targetRow, targetCol - 1] *= matrix[targetRow, targetCol];
            matrix[targetRow, targetCol + 1] *= matrix[targetRow, targetCol];
            matrix[targetRow + 1, targetCol - 1] *= matrix[targetRow, targetCol];
            matrix[targetRow + 1, targetCol] *= matrix[targetRow, targetCol];
            matrix[targetRow + 1, targetCol + 1] *= matrix[targetRow, targetCol];
            matrix[targetRow, targetCol] *= sum;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
