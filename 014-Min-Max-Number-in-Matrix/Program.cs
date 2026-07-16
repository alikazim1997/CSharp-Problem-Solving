using System;

namespace _014_Min_Max_Number_in_Matrix
{
    internal class Program
    {
        // Method to print the matrix with clean formatting
        public void PrintMatrix(int[,] arr)
        {
            Console.WriteLine("--- Matrix ---");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j].ToString().PadLeft(4) + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("--------------");
        }

        // Method to find the minimum number
        public int MinNumberInMatrix(int[,] arr)
        {
            int min = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++) // Start from 0
            {
                for (int j = 0; j < arr.GetLength(1); j++) // Start from 0
                {
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                    }
                }
            }
            return min;
        }

        // Method to find the maximum number
        public int MaxNumberInMatrix(int[,] arr)
        {
            int max = arr[0, 0];
            for (int i = 0; i < arr.GetLength(0); i++) // Start from 0
            {
                for (int j = 0; j < arr.GetLength(1); j++) // Start from 0
                {
                    if (arr[i, j] > max)
                    {
                        max = arr[i, j];
                    }
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            Program e = new Program();
            int[,] matrix1 = { { 77, 5, 12 }, { 22, 20, 6 }, { 14, 3, 9 } };

            e.PrintMatrix(matrix1);

            int min = e.MinNumberInMatrix(matrix1);
            int max = e.MaxNumberInMatrix(matrix1);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Minimum Number is: {min}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Maximum Number is: {max}");
            Console.ResetColor();
        }
    }
}