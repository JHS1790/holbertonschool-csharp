using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix1 = { { 2, 2 }, { -9, 4 } };
        double[,] matrix2 = { { -4, 9, 0 }, { 1, -2, 1 }, { 3, -4, 2 } };

        Console.WriteLine(MatrixMath.Determinant(matrix1));
        Console.WriteLine("--------");
        Console.WriteLine(MatrixMath.Determinant(matrix1));
    }
}
