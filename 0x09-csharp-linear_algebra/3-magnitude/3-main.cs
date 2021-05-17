using System;

class Program
{
	static void Main(string[] args)
	{
		double[] Mag1 = new double[1] { 1 };
		double[] Mag2 = new double[2] { 3, 3 };
		double[] Mag3 = new double[3] { 4, 7 , 8 };
		double[] Mag4 = new double[4] { 4, 7 , 8, 0 };

		Console.WriteLine($"Magnitude is {VectorMath.Magnitude(Mag1)}");
		Console.WriteLine($"Magnitude is {VectorMath.Magnitude(Mag2)}");
		Console.WriteLine($"Magnitude is {VectorMath.Magnitude(Mag3)}");
		Console.WriteLine($"Magnitude is {VectorMath.Magnitude(Mag4)}");
	}
}
