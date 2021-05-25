using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix = { { 5, 0, -2 }, { 1, -8, 1 }, { 3, 2, 0 } };

        Console.WriteLine(MatrixMath.Determinant(matrix));
    }
}
