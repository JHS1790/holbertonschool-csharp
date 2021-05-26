using System;

class MatrixMath
{
    public static double[,] Inverse2D(double[,] matrix)
    {
        if ((matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2) || Determinant2d(matrix) == 0)
            return new double[,] { { -1 } };

        double multicant = 1 / Determinant2d(matrix);

        return MultiplyScalar(matrix, multicant);
    }

    public static double Determinant2d(double[,] matrix)
	{
		return ((matrix[0, 0] * matrix[1, 1]) - (matrix[0, 1] * matrix[1, 0]));
	}
	public static double[,] MultiplyScalar(double[,] matrix, double scalar)
	{
		if (matrix.Length != 4 && matrix.Length != 9)
            return new double[,] { {-1} };

		double[,] answer;

		if (matrix.GetLength(0) == 2)
		{
			answer = new double[2,2];
			for (int i = 0; i < 2; i++)
				for (int j = 0; j < 2; j++)
					answer[i,j] = Math.Round((matrix[i,j] * scalar), 2);
		}
		else
		{
			answer = new double[3,3];
			for (int i = 0; i < 3; i++)
				for (int j = 0; j < 3; j++)
					answer[i,j] = Math.Round((matrix[i,j] * scalar), 2);
		}

		return answer;
	}
}
