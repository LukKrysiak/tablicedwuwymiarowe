using System;

public class NumberArrayFiller
{
    public static void Main(string[] args)
    {
        Console.Write("Podaj rozmiar tablicy: ");
        int size;
        while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
        {
            Console.WriteLine("Niepoprawny rozmiar. Podaj liczbę całkowitą większą od zera.");
            Console.Write("Podaj rozmiar tablicy: ");
        }

        int[,] array = new int[size, size];
        int counter = 1;

        for (int layer = 0; layer < size / 2 + size % 2; layer++)
        {
            int startX = layer;
            int startY = layer;
            int endX = size - 1 - layer;
            int endY = size - 1 - layer;

            // Wypełnianie wiersza górnego
            for (int col = startX; col <= endX; col++)
            {
                array[startY, col] = counter++;
            }

            // Wypełnianie kolumny prawej
            for (int row = startY + 1; row <= endY; row++)
            {
                array[row, endX] = counter++;
            }

            // Wypełnianie wiersza dolnego
            for (int col = endX - 1; col >= startX; col--)
            {
                array[endY, col] = counter++;
            }

            // Wypełnianie kolumny lewej
            for (int row = endY - 1; row > startY; row--)
            {
                array[row, startX] = counter++;
            }
        }

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                Console.Write($"{array[row, col],3} ");
            }
            Console.WriteLine();
        }
    }
}