using System;

namespace ConsoleApp21
{
    internal class Program
    {
        private int Counter = 0;

        // Method to populate the array with sequential numbers
        void FullArrNumber(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Counter++;
                    arr[i, j] = Counter;
                }
            }
        }

        // Method that creates and returns the transposed matrix
        // This handles non-square matrices correctly
        int[,] TransposeMatrix(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            // Create a new array with swapped dimensions (cols x rows)
            int[,] transposed = new int[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transposed[j, i] = arr[i, j];
                }
            }
            return transposed;
        }

        // Method to print the matrix to the console
        void PrintMatrix(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Program myProgram = new Program();

            // Define dimensions (can be square or rectangular)
            int rows = 2, cols = 3;
            int[,] originalArr = new int[rows, cols];

            myProgram.FullArrNumber(originalArr);

            Console.WriteLine("Original Matrix:");
            myProgram.PrintMatrix(originalArr);

            // Transpose the matrix and store the result
            int[,] transposedArr = myProgram.TransposeMatrix(originalArr);

            Console.WriteLine("\nTransposed Matrix:");
            myProgram.PrintMatrix(transposedArr);
        }
    }
}