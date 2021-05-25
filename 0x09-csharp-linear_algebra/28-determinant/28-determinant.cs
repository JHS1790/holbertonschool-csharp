using System;

class MatrixMath
{
	public static double Determinant(double[,] matrix)
	{
		if (matrix.Length == 4)
			return Determinant2d(matrix);
		else if (matrix.Length == 9)
			return Determinant3d(matrix);
		else
			return -1;
	}

	public double Determinant2d(double[,] matrix)
	{
		return ((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]));
	}

	public double Determinant3d(double[,] matrix)
	{
		double[,] a = new double[,] { { matrix[1,1] , matrix[1,2] } , { matrix[2,1] , matrix[2,2] } };
		double[,] b = new double[,] { { matrix[1,0] , matrix[1,2] } , { matrix[2,0] , matrix[2,2] } };
		double[,] c = new double[,] { { matrix[1,0] , matrix[1,1] } , { matrix[2,0] , matrix[2,1] } };
		return ( ( matrix[0,0] * Determinant2d(a) ) - ( matrix[1,0] * Determinant2d(b) ) - ( matrix[2,0] * Determinant2d(c) ) );
	}
}
