using System;

namespace MatrixOperations
{
    internal class Program
    {
        // Use static readonly for Random to avoid repeated initialization
        private static readonly Random _random = new Random();

        // Fills the matrix with random integers between 1 and 10
        public void FillMatrix(int[,] matrix)
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

        // Prints the entire matrix in a structured format
        public void PrintMatrix(int[,] matrix)
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

        // Prints only the elements of the middle column
        public void PrintMiddleColumn(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int middleColIndex = matrix.GetLength(1) / 2;

            Console.WriteLine("Middle Column:");
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"{matrix[i, middleColIndex]:D2}");
            }
        }

        // Prints only the elements of the middle row
        public void PrintMiddleRow(int[,] matrix)
        {
            int cols = matrix.GetLength(1);
            int middleRowIndex = matrix.GetLength(0) / 2;

            Console.WriteLine("Middle Row:");
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"{matrix[middleRowIndex, j]:D2}\t");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Program matrixApp = new Program();
            int[,] myMatrix = new int[3, 3];

            matrixApp.FillMatrix(myMatrix);

            Console.WriteLine("Full Matrix:");
            matrixApp.PrintMatrix(myMatrix);

            Console.WriteLine();
            matrixApp.PrintMiddleColumn(myMatrix);

            Console.WriteLine();
            matrixApp.PrintMiddleRow(myMatrix);
        }
    }
}