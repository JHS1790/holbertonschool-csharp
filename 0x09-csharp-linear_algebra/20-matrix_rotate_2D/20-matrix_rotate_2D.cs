using System;

class MatrixMath
{
	public static double[,] Rotate2D(double[,] matrix, double angle)
	{
		if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
			return new double[,] { { -1 } };

		double[,] rotation_matrix = new double[,] { { Math.Cos(angle), -(Math.Sin(angle)) }, { Math.Sin(angle), Math.Cos(angle) } };

		double[,] answer = new double[2, 2];

		for (int i = 0; i < 2; i++)
			for (int j = 0; j < 2; j++)
				answer[i, j] = Math.Round(DotProduct(RowBuilder(matrix, i), ColumnBuilder(rotation_matrix, j)), 2);

		return answer;
	}

	public static double[] RowBuilder(double[,] matrix, int rowNumber)
	{
		double[] row = new double[matrix.GetLength(1)];
		
		for (int i = 0; i < matrix.GetLength(1); i++)
			row[i] = matrix[rowNumber, i];

		return row;
	}
	
	public static double[] ColumnBuilder(double[,] matrix, int columnNumber)
	{
		double[] column = new double[matrix.GetLength(0)];
		
		for (int i = 0; i < matrix.GetLength(0); i++)
			column[i] = matrix[i, columnNumber];

		return column;
	}

	public static double DotProduct(double[] vector1, double[] vector2)
	{
		double[] interim_answer = new double[vector1.Length];
		double answer = 0;

		for (int i = 0; i < vector1.Length; i++)
			interim_answer[i] = vector1[i] * vector2[i];

		foreach (double part in interim_answer)
			answer += part;

		return answer;
	}
}
