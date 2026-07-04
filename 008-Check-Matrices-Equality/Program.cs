using System;

namespace _008_Check_Matrices_Equality
{
    internal class Program
    {
        private static readonly Random _random = new Random();

        // Method to fill the matrix with random numbers
        public static void FillMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = _random.Next(1, 11);
                }
            }
        }

        // Method to compare two matrices for equality
        public static bool AreEqualMatrices(int[,] matrix1, int[,] matrix2)
        {
            // 1. Check if dimensions match first
            if (matrix1.GetLength(0) != matrix2.GetLength(0) ||
                matrix1.GetLength(1) != matrix2.GetLength(1))
            {
                return false;
            }

            // 2. Compare each element with its counterpart
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    // If any mismatch is found, return false immediately
                    if (matrix1[i, j] != matrix2[i, j])
                    {
                        return false;
                    }
                }
            }

            // 3. If the loop completes without returning, the matrices are equal
            return true;
        }

        // Method to print the matrix in a formatted way
        public static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j]:D2}\t");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int[,] matrix1 = new int[4, 4];
            int[,] matrix2 = new int[4, 4];

            FillMatrix(matrix1);
            FillMatrix(matrix2);

            Console.WriteLine("Matrix 1:");
            PrintMatrix(matrix1);

            Console.WriteLine("\nMatrix 2:");
            PrintMatrix(matrix2);

            // Call the equality check method
            if (AreEqualMatrices(matrix1, matrix2))
            {
                Console.WriteLine("\nYES: Both matrices are equal.");
            }
            else
            {
                Console.WriteLine("\nNO: Matrices are NOT equal.");
            }
        }
    }
}