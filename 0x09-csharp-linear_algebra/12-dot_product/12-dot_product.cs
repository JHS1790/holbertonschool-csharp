using System;

class VectorMath
{
	public static double DotProduct(double[] vector1, double[] vector2)
	{
		if((vector1.Length > 3 || vector1.Length < 2) || (vector1.Length != vector2.Length))
            return -1;
			
		double[] interim_answer = new double[vector1.Length];
		double answer = 0;

		for (int i = 0; i < vector1.Length; i++)
			interim_answer[i] = vector1[i] * vector2[i];

		foreach (double part in interim_answer)
			answer += part;

		return answer;
	}
}
