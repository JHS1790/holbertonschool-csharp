  using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "C# (pronounced \"See Sharp\") is a simple, modern, object-oriented, and type-safe programming language. C# has its roots in the C family of languages and will be immediately familiar to C, C++, Java, and JavaScript programmers.";
		str = str.Remove(0, 49).Remove(15) + str.Remove(0, 79).Remove(12) + str.Remove(0, 118).Remove(4) + str.Remove(2);
		Console.WriteLine(str);
        }
}
