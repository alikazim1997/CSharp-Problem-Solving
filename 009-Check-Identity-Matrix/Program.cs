using System;

namespace _009_Check_Identity_Matrix
{
    internal class Program
    {
        // تم تغيير Console.WriteLine إلى Console.Write ليتم طباعة المصفوفة كصف وليس أعمدة
        static void PrintMatrix(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine(); // للانتقال لسطر جديد بعد كل صف
            }
        }

        // تم إضافة static ليمكن استدعاؤها من Main
        static bool IsIdentityMatrix(int[,] arr)
        {
            // التحقق من أن المصفوفة مربعة (اختياري ولكنه مهم)
            if (arr.GetLength(0) != arr.GetLength(1)) return false;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == j && arr[i, j] != 1)
                    {
                        return false; // القطر الرئيسي يجب أن يكون 1
                    }
                    else if (i != j && arr[i, j] != 0)
                    {
                        return false; // العناصر الأخرى يجب أن تكون 0
                    }
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int[,] matrix = {
                { 1, 0, 0 },
                { 0, 1, 0 },
                { 0, 0, 1 }
            };

            PrintMatrix(matrix);
            Console.WriteLine("Is Identity Matrix: " + IsIdentityMatrix(matrix));
        }
    }
}