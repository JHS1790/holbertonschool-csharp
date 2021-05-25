using System;

class MatrixMath
{
	public static double Determinant(double[,] matrix)
	{
		if (matrix.Length == 4)
			return Math.Round(Determinant2d(matrix), 2);
		else if (matrix.Length == 9)
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
		return ( ( matrix[0,0] * Determinant2d(a) ) - ( matrix[1,0] * Determinant2d(b) ) - ( matrix[2,0] * Determinant2d(c) ) );
	}
}
