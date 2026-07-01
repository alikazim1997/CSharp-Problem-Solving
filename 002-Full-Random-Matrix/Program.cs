using System;
namespace _002_Full_Random_Matrix
{
    internal class Program
    {
        private static Random _random = new Random();
        private  int _GetRandomNumber() => _random.Next(1,101);
        public void Full_Arr_Number(int[,]arr )
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j <arr.GetLength(1); j++)
                {
                    arr[i,j] = _GetRandomNumber();
                }
            }


        }
        public void Print_Arr_Number(int[,] arr)
        {
            Full_Arr_Number(arr);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]+"\t");
                }
                Console.WriteLine();
            }


        }
        static void Main(string[] args)
        {
            Program m = new Program();
            int Row = 2;
            int Col = 3;    
            int[,] arr = new int[Row, Col];
            
            m.Print_Arr_Number(arr);
        }
    }
}
