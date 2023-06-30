using System;

public class NumberArrayFiller
{
    public static void Main(string[] args)
    {
        int[,] array = new int[10, 10];

        for (int row = 0; row < 10; row++)
        {
            if (row % 2 == 0) // Parzyste wiersze
            {
                for (int col = 0; col < 10; col++)
                {
                    array[row, col] = row * 10 + col + 1;
                }
            }
            else // Nieparzyste wiersze
            {
                for (int col = 0; col < 10; col++)
                {
                    array[row, col] = (row + 1) * 10 - col;
                }
            }
        }

        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                Console.Write($"{array[row, col],3} ");
            }
            Console.WriteLine();
        }
    }
}