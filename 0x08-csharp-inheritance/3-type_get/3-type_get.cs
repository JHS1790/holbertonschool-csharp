using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Globalization;
using System.Text;

///<summary>an object</summary>
class Obj
{
    ///<summary>a method that prints the names of the available properties and methods of an object</summary>
    public static void Print(object myObj)
    {
        TypeInfo t = myObj.GetType().GetTypeInfo();
        IEnumerable<PropertyInfo> pList = t.DeclaredProperties;
        IEnumerable<MethodInfo> mList = t.DeclaredMethods;

        Console.WriteLine($"{t.Name} Properties:");
        foreach (PropertyInfo p in pList)
        {
            if (p.Name.StartsWith("System."))
                continue;
            Console.WriteLine($"{p.Name}");
        }
        Console.WriteLine($"{t.Name} Methods:");
        foreach (MethodInfo m in mList)
        {
            if (m.Name.StartsWith("System."))
                continue;
            Console.WriteLine($"{m.Name}");
        }
    }
}
