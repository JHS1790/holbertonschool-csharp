using System;

class MatrixMath
{
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
					answer[i,j] = matrix[i,j] * scalar;
		}
		else
		{
			answer = new double[3,3];
			for (int i = 0; i < 3; i++)
				for (int j = 0; j < 3; j++)
					answer[i,j] = matrix[i,j] * scalar;
		}

		return answer;
	}
}
