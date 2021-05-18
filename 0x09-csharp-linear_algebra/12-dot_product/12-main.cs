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

        Console.WriteLine($"short x good: [{string.Join(", ", VectorMath.DotProduct(vec11, vec21))}]");
        Console.WriteLine($"good x short: [{string.Join(", ", VectorMath.DotProduct(vec21, vec11))}]");
        Console.WriteLine($"short x short: [{string.Join(", ", VectorMath.DotProduct(vec12, vec11))}]");
        
        Console.WriteLine($"good2d x good2d: [{string.Join(", ", VectorMath.DotProduct(vec21, vec22))}]");
        Console.WriteLine($"good2d x good3d: [{string.Join(", ", VectorMath.DotProduct(vec21, vec31))}]");
        Console.WriteLine($"good3d x good2d: [{string.Join(", ", VectorMath.DotProduct(vec31, vec21))}]");
        Console.WriteLine($"good3d x good3d: [{string.Join(", ", VectorMath.DotProduct(vec31, vec32))}]");
        
        Console.WriteLine($"good x long: [{string.Join(", ", VectorMath.DotProduct(vec21, vec41))}]");
        Console.WriteLine($"long x good: [{string.Join(", ", VectorMath.DotProduct(vec41, vec21))}]");
        Console.WriteLine($"long x long: [{string.Join(", ", VectorMath.DotProduct(vec41, vec42))}]");
    }
}
