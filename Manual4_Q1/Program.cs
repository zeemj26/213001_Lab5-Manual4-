using System;

class Program
{
    static void Main()
    {
        // Initialize a two-dimensional array of integers
        int[,] myArray = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        // Call the Print2DArray method to display the elements
        Print2DArray(myArray);
    }

    static void Print2DArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine(); // Move to the next row
        }
    }
}
