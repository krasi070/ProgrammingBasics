using System;

class MatrixOfPalindromes
{
    static void Main()
    {
        Console.Write("Enter rows: ");
        int r = int.Parse(Console.ReadLine());
        Console.Write("Enter columns: ");
        int c = int.Parse(Console.ReadLine());
        string[,] matrix = new string[r, c];
        char fstChar;
        char sndChar;
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                fstChar = Convert.ToChar('a' + i);
                sndChar = Convert.ToChar('a' + i + j);
                matrix[i, j] = Convert.ToString(fstChar);
                matrix[i, j] += Convert.ToString(sndChar);
                matrix[i, j] += Convert.ToString(fstChar);
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

