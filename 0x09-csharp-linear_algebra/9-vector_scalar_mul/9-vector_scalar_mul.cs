using System;

class VectorMath
{
	public static double[] Multiply(double[] vector, double scalar)
	{
		if(vector.Length > 3 || vector.Length < 2)
            return new double[1] { -1 };

		double[] answer = new double[vector.Length];

		for (int i = 0; i < vector.Length; i++)
			answer[i] = vector[i] * scalar;

		return answer;
	}
}
