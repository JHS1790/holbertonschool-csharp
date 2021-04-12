using System;

class Program
{
	static void Main(string[] args)
	{
		double percent = .7553;
		double currency = 98765.4321;
		Console.OutputEncoding = System.Text.Encoding.UTF8;
		Console.WriteLine("Percent: {0:P}\nCurrency: {1:C}", percent, currency);
	}
}
