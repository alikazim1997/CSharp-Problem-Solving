using System;

namespace _003_Sum_Each_Row_in_Matrix
{
    internal class Program
    {
        private Random random = new Random();

        /// <summary>
        /// Fills the 2D array with random integers between 1 and 100.
        /// </summary>
        public void FillArray(int[,] arr)
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
        /// Prints the matrix to the console in a tabular format.
        /// </summary>
        public void PrintArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write( arr[i, j] + "\t");
                }
                Console.WriteLine(); // Move to the next row
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Calculates the sum of a specific row in the matrix.
        /// </summary>
        /// <param name="row">The index of the row to sum.</param>
        /// <returns>The total sum of the row.</returns>
        public int Sum(int[,] arr, int row)
        {
            int sum = 0;
            // Iterate through each column in the specified row
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                sum += arr[row, col];
            }
            return sum;
        }

        /// <summary>
        /// Iterates through all rows and prints their calculated sums.
        /// </summary>
        public void Sum_Arr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.WriteLine($"The Sum of Row [{i + 1}]: {Sum(arr, i)}");
            }
        }

        static void Main(string[] args)
        {
            Program m = new Program();
            int[,] arr = new int[5, 3]; // Defining a 5x3 matrix

            m.FillArray(arr);
            m.PrintArray(arr);
            m.Sum_Arr(arr);
        }
    }
}