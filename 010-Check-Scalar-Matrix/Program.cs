using System;
namespace _010_Check_Scalar_Matrix
{
    internal class Program
    {

        static void PrintMatrix(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine(); // Move to a new line after each row
            }
        }

        // Method to check if the given matrix is an Identity Matrix
        static bool IsIdentityMatrix(int[,] arr)
        {
            // Check if the matrix is square (rows must equal columns)
            if (arr.GetLength(0) != arr.GetLength(1)) return false;
            int FirstDiagElemement = arr[0,0];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    // The main diagonal elements must be 1
                    if (i == j && arr[i, j] != FirstDiagElemement)
                    {
                        return false;
                    }
                    // All other elements must be 0
                    else if (i != j && arr[i, j] != 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }


        static void Main(string[] args)
        {
            int[,] matrix = {
                { 4, 0, 0 },
                { 0, 4, 0 },
                { 0, 0, 4}
            };

            PrintMatrix(matrix);
            Console.WriteLine("Is Identity Matrix: " + IsIdentityMatrix(matrix));




        }
    }
}
