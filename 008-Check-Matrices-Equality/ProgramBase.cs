namespace _008_Check_Matrices_Equality
{
    internal class ProgramBase
    {
        public bool AreEqualMatrices(int[,] matrix1,
                                    int[,] matrix2)
        {
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    return matrix1[i, j] == matrix2[i, j];
                }
            }
            return false;   
        }
    }
}