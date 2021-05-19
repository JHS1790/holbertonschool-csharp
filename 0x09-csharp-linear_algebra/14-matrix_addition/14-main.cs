using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix11 = { { 1 } };
        double[,] matrix21 = { { 1, 1 }, { 1, 1 } };
        double[,] matrix22 = { { 2, 2 }, { 2, 2 } };
        double[,] matrix31 = { { 3, 3, 3 }, { 3, 3, 3 }, {3, 3, 3} };
        double[,] matrix32 = { { 4, 4, 4 }, { 4, 4, 4 }, {4, 4, 4} };
        
        PrintMatrix(MatrixMath.Add(matrix11, matrix21));
        PrintMatrix(MatrixMath.Add(matrix21, matrix22));
        PrintMatrix(MatrixMath.Add(matrix21, matrix32));
        PrintMatrix(MatrixMath.Add(matrix31, matrix32));
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
