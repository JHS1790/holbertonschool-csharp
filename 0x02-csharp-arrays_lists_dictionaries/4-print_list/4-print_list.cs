using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List<int> new_list = new List<int>();
        for (int i= 0; i < size; i++)
        {
            new_list.Add(i);
            Console.Write("{0}{1}",i , i == size-1 ? "":" ");
        }
        Console.Write("\n");
        return new_list;
    }
}
