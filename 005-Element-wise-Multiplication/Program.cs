using System;
namespace _005_Element-wise Multiplication
{
    class clsMultiply_Matrices
    {
        Random rad = new Random();
       public void FillMatrix(int[,]arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0;  j < arr.GetLength(1); j++)
                {
                    arr[i,j]=rad.Next(1,11);
                }
            }
        }
      public  void PrintMatrix(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i,j]:D2}\t");
                }
                Console.WriteLine();
            }
        }
        public void MultiplyMatrix(int[,] Mateix1, int[,] Materixl2, int[,]MateixResults)
        {
            for (int i = 0; i < Mateix1.GetLength(0); i++)
            {
                for (int j = 0; j < Mateix1.GetLength(1); j++)
                {
                    MateixResults[i, j] = Mateix1[i,j]* Materixl2[i,j];
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Matrix1 = new int[3, 3];
            int[,] Matrix2 = new int[3, 3];
            int[,] MatrixResults = new int[3, 3];
            clsMultiply_Matrices Multiply_Matrices = new clsMultiply_Matrices();
            Multiply_Matrices.FillMatrix(Matrix1);
            Multiply_Matrices.PrintMatrix(Matrix1);
            Console.WriteLine();
            Multiply_Matrices.FillMatrix(Matrix2);
            Multiply_Matrices.PrintMatrix(Matrix2);
            Console.WriteLine("--------------------");
            Multiply_Matrices.MultiplyMatrix(Matrix1, Matrix2, MatrixResults);
           Multiply_Matrices.PrintMatrix(MatrixResults); 



        }
    }
}
