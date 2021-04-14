using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> Keys = new List<string>();
        List<object> Values = new List<object>();

        foreach (KeyValuePair<string, string> pair in myDict)
        {
            Keys.Add(pair.Key);
            Values.Add(pair.Value);
        }

        var newdict = new Dictionary<string, object>();
        for (int i = 0; i < Keys.Count; i++) 
            newdict.Add(Keys[i], Values[i]);
        Keys.Sort();
        for (int i = 0; i < Keys.Count; i++)
        {
            Console.WriteLine($"{Keys[i]}: {newdict[Keys[i]]}");
        }
    }
}
