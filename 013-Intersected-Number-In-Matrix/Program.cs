using System;

namespace _013_Intersected_Number_In_Matrice
{
    internal class Program
    {
        // Method to print the matrix in a readable format
        public void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        // Method to check if a specific number exists in a given matrix
        bool IsNumberInMatrix(int[,] matrix, int number)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == number)
                    {
                        return true; // Found the number
                    }
                }
            }
            return false; // Number not found
        }

        // Method to find and print numbers that exist in both matrices
        public void PrintIntersectedNumbers(int[,] arr1, int[,] arr2)
        {
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    int number = arr1[i, j];

                    // Check if the current number from arr1 exists in arr2
                    if (IsNumberInMatrix(arr2, number))
                    {
                        Console.Write($"{number} ");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Program E = new Program();
            int[,] matrix = { { 77, 5, 12 }, { 22, 20, 1 }, { 1, 0, 9 } };
            int[,] matrix2 = { { 5, 80, 90 }, { 22, 77, 1 }, { 10, 8, 33 } };

            Console.WriteLine("Matrix1:");
            E.Print(matrix);

            Console.WriteLine("Matrix2:");
            E.Print(matrix2);

            Console.Write("\nIntersected Numbers are: ");
            E.PrintIntersectedNumbers(matrix, matrix2);

            Console.WriteLine(); // Final newline
        }
    }
}