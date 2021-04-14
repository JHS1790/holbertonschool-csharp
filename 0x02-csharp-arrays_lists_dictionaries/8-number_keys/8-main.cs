using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> myDict = new Dictionary<string, string>();

        Console.WriteLine("Number of keys: {0}", Dictionary.NumberOfKeys(myDict));
        
        myDict.Add("language", "C");
        myDict.Add("track", "low level");
        myDict.Add("school", "Holberton");

        Console.WriteLine("Number of keys: {0}", Dictionary.NumberOfKeys(myDict));
    }
}
