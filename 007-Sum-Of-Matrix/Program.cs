using System;


namespace _007_Sum_Of_Matrix
{
    internal class Program
    {

        private static readonly Random _random = new Random();


        public void FillMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = _random.Next(1, 21);
                }
            }


        }
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
        public int Sum_Matrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int Sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Sum += matrix[i, j];
                }
            } 
            return Sum; 
        }
        static void Main(string[] args)
        {
            Program e = new Program();
            int[,] arr = new int[3, 3];
            e.FillMatrix(arr);
            e.PrintMatrix(arr);
            int Sum = e.Sum_Matrix(arr);
            Console.WriteLine("\nSum of Matrix1 is: " +Sum); 
        }
    }
}
