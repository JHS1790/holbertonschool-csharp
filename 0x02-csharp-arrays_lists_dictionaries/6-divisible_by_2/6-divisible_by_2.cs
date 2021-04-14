using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> div2List = new List<bool>();
        foreach (int number in myList)
        {
            if (number % 2 == 0)
                div2List.Add(true);
            else
                div2List.Add(false);
        }
        return div2List;
    }
}
