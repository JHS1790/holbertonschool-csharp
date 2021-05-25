using System;

namespace _16_matrix_scalar_mul
{
    class Program
    {
    static void Main(string[] args)
    {
        double[,] matrix1 = { { 2, 3 }, { -1, 0 }};
        double[,] matrix2 = { { 1, 7 }, { -8, -2 } };
        double scalar1 = 2;

        PrintMatrix(MatrixMath.MultiplyScalar(matrix1, scalar1));
    }

    static void PrintMatrix(double[,] matrix)
    {
        int rowLength = matrix.GetLength(0);
        int colLength = matrix.GetLength(1);

        for (int i = 0; i < rowLength; i++)
        {
            for (int j = 0; j < colLength; j++)
            {
                Console.Write(string.Format("{0} ", matrix[i, j]));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    }
}
