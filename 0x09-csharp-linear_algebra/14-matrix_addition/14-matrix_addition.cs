using System;

class MatrixMath
{
	public static double[,] Add(double[,] matrix1, double[,] matrix2)
	{
		if (matrix1.Length != 4 && matrix1.Length != 9)
            return new double[,] { {-1} };
		if (matrix1.Length != matrix2.Length)
            return new double[,] { {-1} };

		double[,] answer;

		if (matrix1.Length == 4)
		{
			answer = new double[2,2];
			for (int i = 0; i < 2; i++)
				for (int j = 0; j < 2; j++)
					answer[i,j] = matrix1[i,j] + matrix2[i,j];
		}
		else
		{
			answer = new double[3,3];
			for (int i = 0; i < 3; i++)
				for (int j = 0; j < 3; j++)
					answer[i,j] = matrix1[i,j] + matrix2[i,j];
		}
		
		return answer;
	}
}
