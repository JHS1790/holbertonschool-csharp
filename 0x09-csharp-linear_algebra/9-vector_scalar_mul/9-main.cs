using System;

class Program
{
    static void Main(string[] args)
    {
		double[] Mag1 = new double[1] { 1 };
		double[] Mag2 = new double[2] { 3, 3 };
		double[] Mag3 = new double[3] { 4, 7 , 8 };
		double[] Mag4 = new double[4] { 4, 7 , 8, 0 };
        
        Console.WriteLine($"[{string.Join(", ", VectorMath.Multiply(Mag1, 2))}]");
        Console.WriteLine($"[{string.Join(", ", VectorMath.Multiply(Mag2, 2))}]");
        Console.WriteLine($"[{string.Join(", ", VectorMath.Multiply(Mag3, 2))}]");
        Console.WriteLine($"[{string.Join(", ", VectorMath.Multiply(Mag4, 2))}]");
    }
}
