using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix1 = { { 1, 2, 3 }, { -4, 5, 6 } };
        double[,] matrix2 = { { -6, 1 }, { -3, 9 }, { 2, 4 } };
        double[,] result;

        result = MatrixMath.Multiply(matrix1, matrix2);

        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Console.Write(result[i, j]);
                if (j != result.GetLength(1) - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}
