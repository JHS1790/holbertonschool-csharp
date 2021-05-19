﻿using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix1 = { { 2, 3 }, { -1, 0 }};
        double[,] matrix2 = { { 1, 7 }, { -8, -2 } };

        PrintMatrix(MatrixMath.Multiply(matrix1, matrix2));
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
        
    }
}
