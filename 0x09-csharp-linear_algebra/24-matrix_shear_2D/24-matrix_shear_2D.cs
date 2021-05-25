using System;

class MatrixMath
{
	public static double[,] Shear2D(double[,] matrix, char direction, double factor)
	{
		if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2 || ( direction != 'x' && direction != 'y'))
			return new double[,] { { -1 } };

	}
}
