using System;

class MatrixMath
{
	public static double Determinant(double[,] matrix)
	{
		if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
			return Math.Round(Determinant2d(matrix), 2);
		else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
			return Math.Round(Determinant3d(matrix), 2);
		else
			return -1;
	}

	public static double Determinant2d(double[,] matrix)
	{
		return ((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]));
	}

	public static double Determinant3d(double[,] matrix)
	{
		double[,] a = new double[,] { { matrix[1,1] , matrix[1,2] } , { matrix[2,1] , matrix[2,2] } };
		double[,] b = new double[,] { { matrix[1,0] , matrix[1,2] } , { matrix[2,0] , matrix[2,2] } };
		double[,] c = new double[,] { { matrix[1,0] , matrix[1,1] } , { matrix[2,0] , matrix[2,1] } };
		/*
		Console.WriteLine("Matrix:");
		for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j]);
                if (j != matrix.GetLength(1) - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
    	Console.WriteLine("----------");
		Console.WriteLine("a subatrix:");
		for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[i, j]);
                if (j != a.GetLength(1) - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
    	Console.WriteLine("----------");
		Console.WriteLine("b subatrix:");
		for (int i = 0; i < b.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                Console.Write(b[i, j]);
                if (j != b.GetLength(1) - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
    	Console.WriteLine("----------");
		Console.WriteLine("c subatrix:");
		for (int i = 0; i < c.GetLength(0); i++)
        {
            for (int j = 0; j < c.GetLength(1); j++)
            {
                Console.Write(c[i, j]);
                if (j != c.GetLength(1) - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
        }
    	Console.WriteLine("----------");
		*/
		return ( ( matrix[0,0] * Determinant2d(a) ) - ( matrix[0,1] * Determinant2d(b) ) - ( matrix[0,2] * Determinant2d(c) ) );
	}
}
