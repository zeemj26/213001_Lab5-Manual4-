using System;

class Program
{
    static void Main()
    {
        int[,] matrixA = new int[3, 3];
        int[,] matrixB = new int[3, 3];

        Console.WriteLine("Enter elements for Matrix A:");
        InitializeMatrix(matrixA);

        Console.WriteLine("Enter elements for Matrix B:");
        InitializeMatrix(matrixB);

        int[,] resultMatrix = MultiplyMatrices(matrixA, matrixB);

        Console.WriteLine("Matrix A:");
        DisplayMatrix(matrixA);

        Console.WriteLine("Matrix B:");
        DisplayMatrix(matrixB);

        Console.WriteLine("Resultant Matrix (A x B):");
        DisplayMatrix(resultMatrix);
    }

    static void InitializeMatrix(int[,] matrix)
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write($"Enter element at row {row + 1}, column {col + 1}: ");
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }
    }

    static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
    {
        int[,] resultMatrix = new int[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                resultMatrix[i, j] = 0;
                for (int k = 0; k < 3; k++)
                {
                    resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return resultMatrix;
    }

    static void DisplayMatrix(int[,] matrix)
    {
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}

