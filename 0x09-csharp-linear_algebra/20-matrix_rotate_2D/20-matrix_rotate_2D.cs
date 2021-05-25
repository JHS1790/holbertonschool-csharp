using System;

class MatrixMath
{
	public static double[,] Rotate2D(double[,] matrix, double angle)
	{
		if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
			return new double[,] { { -1 } };

		double[,] rotation_matrix = new double[,] { { Math.Cos(angle), -(Math.Sin(angle)) }, { Math.Sin(angle), Math.Cos(angle) } };
/*
		double[] row1 = RowBuilder(matrix, 0);
		double[] row2 = RowBuilder(matrix, 1);
		double[,] row1a = new double[,] { { row1[0], row1[1] } };
		double[,] row2a = new double[,] { { row2[0], row2[1] } };
		double[,] row1b = Multiply(row1a, rotation_matrix);
		double[,] row2b = Multiply(row2a, rotation_matrix);
		
		double[,] answer = new double[,] { { row1b[0,0], row1b[0,1] } , { row2b[0,0], row2b[0,1] } };
*/
		double[,] answer = Multiply(matrix, rotation_matrix);
		
		return answer;
	}

	public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
	{
		if (matrix1.GetLength(1) != matrix2.GetLength(0))
			return new double[,] { { -1 } };

		int columnLength = matrix1.GetLength(0);
		int rowLength = matrix2.GetLength(1);

		double[,] answer = new double[columnLength, rowLength];

		for (int i = 0; i < columnLength; i++)
			for (int j = 0; j < rowLength; j++)
				answer[i, j] = Math.Round(DotProduct(RowBuilder(matrix1, i), ColumnBuilder(matrix2, j)), 2);

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
