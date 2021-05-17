using System;

class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        double answer = 0;

        if(vector.Length > 3 || vector.Length < 2)
            return -1;
        
        for (int i = 0; i < vector.Length; i++)
            answer += Math.Pow(vector[i], 2);

        return Math.Round(Math.Sqrt(answer), 2);
    }
}
