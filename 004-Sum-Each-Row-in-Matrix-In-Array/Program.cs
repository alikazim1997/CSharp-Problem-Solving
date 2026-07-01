using System;

namespace _004_Sum_Each_Row_in_Matrix_In_Array
{
    internal class Program
    {
        private static Random random = new Random();

        /// <summary>
        /// Populates the 2D array with random integers ranging from 1 to 100.
        /// </summary>
        public static void FillArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(1, 101);
                }
            }
        }

        /// <summary>
        /// Displays the 2D array contents in a formatted table layout.
        /// </summary>
        public static void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Calculates the sum of all elements in a specific row.
        /// </summary>
        /// <returns>The calculated total sum of the row.</returns>
        public static int GetRowSum(int[,] arr, int row)
        {
            int sum = 0;
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                sum += arr[row, col];
            }
            return sum;
        }

        /// <summary>
        /// Iterates through the matrix rows and stores each row's sum into a 1D array.
        /// </summary>
        public static void CalculateAndStoreRowSums(int[,] matrix, int[] sums)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sums[i] = GetRowSum(matrix, i);
            }
        }

        /// <summary>
        /// Outputs the final calculated sums from the 1D array to the console.
        /// </summary>
        public static void PrintArraySums(int[] sums)
        {
            Console.WriteLine("--- Row Sums Results ---");
            for (int i = 0; i < sums.Length; i++)
            {
                Console.WriteLine($"The Sum of Row [{i + 1}]: {sums[i]}");
            }
        }

        static void Main(string[] args)
        {
            int rows = 3, cols = 3;
            int[,] matrix = new int[rows, cols];
            int[] rowSums = new int[rows];

            // Execution steps
            FillArray(matrix);
            PrintArray(matrix);

            CalculateAndStoreRowSums(matrix, rowSums);
            PrintArraySums(rowSums);
        }
    }
}