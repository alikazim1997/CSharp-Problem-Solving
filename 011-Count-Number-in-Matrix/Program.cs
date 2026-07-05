using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Count_Number_in_Matrix
{
    internal class Program
    {
        // Method to display the matrix on the console
        public void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Method to count occurrences of a specific number in the matrix
        public int CountNumberInMatrix(int[,] arr, int number)
        {
            int count = 0; // Initialize a counter to track occurrences

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    // Check if the current element matches the target number
                    if (arr[i, j] == number)
                    {
                        count++; // Increment the counter
                    }
                }
            }

            return count; // Return the total count
        }

        static void Main(string[] args)
        {
            int[,] Matrix1 = { { 9, 1, 12 }, { 0, 9, 1 }, { 0, 9, 9 } };

            Program e = new Program();

            e.Print(Matrix1);

            // Call the method and store the result
            int result = e.CountNumberInMatrix(Matrix1, 9);

            // Print the final result
            Console.WriteLine("Occurrences: " + result);
        }
    }
}