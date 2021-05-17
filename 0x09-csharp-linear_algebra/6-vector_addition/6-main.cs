using System;


class Program
{
    static void Main(string[] args)
    {
		double[] vec11 = new double[1] { 1 };
		double[] vec12 = new double[1] { 1 };
		double[] vec21 = new double[2] { 1, 1 };
		double[] vec22 = new double[2] { 2, 2 };
		double[] vec31 = new double[3] { 3, 3, 3 };
		double[] vec32 = new double[3] { 4, 4, 4 };
		double[] vec41 = new double[4] { 4, 4, 4, 4 };
		double[] vec42 = new double[4] { 4, 4, 4, 4 };
        
        foreach(var item in VectorMath.Add(vec11, vec12))
            Console.Write(item.ToString());
        
        foreach(var item in VectorMath.Add(vec21, vec22))
            Console.Write(item.ToString());
        
        foreach(var item in VectorMath.Add(vec31, vec32))
            Console.Write(item.ToString());
        
        foreach(var item in VectorMath.Add(vec41, vec42))
            Console.Write(item.ToString());
    }
}
