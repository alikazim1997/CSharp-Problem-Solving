using System;

namespace MatrixOperations
{
    internal class Program
    {
        // Searches for a specific number in a 2D matrix
        public static bool IsNumberInMatrix(int[,] matrix, int number)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == number)
                        return true;
                }
            }
            return false;
        }

        // Prints the matrix in a clean, tabulated format
        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] matrix1 = { { 77, 5, 12 }, { 22, 20, 1 }, { 1, 0, 9 } };
            int targetNumber = 77;

            Console.WriteLine("--- Matrix Content ---");
            PrintMatrix(matrix1);
            Console.WriteLine("----------------------");

            // Perform search and output the result
            if (IsNumberInMatrix(matrix1, targetNumber))
            {
                Console.WriteLine($"\nSuccess: The number {targetNumber} was found in the matrix.");
            }
            else
            {
                Console.WriteLine($"\nResult: The number {targetNumber} was not found.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}