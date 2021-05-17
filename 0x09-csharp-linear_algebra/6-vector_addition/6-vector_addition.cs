using System;

class VectorMath
{
	public static double[] Add(double[] vector1, double[] vector2)
	{
		if(vector1.Length > 3 || vector1.Length < 2)
            return new double[1] { -1 };
		if(vector2.Length != vector1.Length)
			return new double[1] { -1 };
		
		double[] answer = new double[vector1.Length];

        for (int i = 0; i < vector1.Length; i++)
			answer[i] = vector1[i] + vector2[i];

		return answer;
	}
}
