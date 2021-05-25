using System;

class MatrixMath
{
	public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
	{
		//if (matrix1.GetLength(0) == 0 || matrix1.GetLength(1) == 0 || matrix2.GetLength(0) == 0 || matrix2.GetLength(1) == 0)
		//	return new double[,] { { -1 } };

		int columnLength = matrix1.GetLength(0);
		int rowLength = matrix2.GetLength(1);

		double[,] answer = new double[columnLength, rowLength];

		for (int i = 0; i < columnLength; i++)
			for (int j = 0; j < rowLength; j++)
				answer[i, j] = DotProduct(RowBuilder(matrix1, i), ColumnBuilder(matrix2, j));

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
