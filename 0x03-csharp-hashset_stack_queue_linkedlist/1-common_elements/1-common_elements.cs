using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        SortedSet<int> commonSet = new SortedSet<int>();

        for (int i = 0; i < list1.Count; i++)
            for (int j = 0; j < list2.Count; j++)
                if (list1[i] == list2[j])
                {
                    commonSet.Add(list1[i]);
                    break;
                }
        List<int> commonList = new List<int>(commonSet);
        return commonList;
    }
}
