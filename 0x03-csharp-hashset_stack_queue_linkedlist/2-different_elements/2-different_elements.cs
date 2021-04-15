using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        SortedSet<int> uncommonSet = new SortedSet<int>();

        for (int i = 0; i < list1.Count; i++)
        {
            bool is_common = false;
            for (int j = 0; j < list2.Count; j++)
            {
                if (list1[i] == list2[j])
                {
                    is_common = true;
                    break;
                }
            }
            if (is_common == false)
                uncommonSet.Add(list1[i]);
        }
        for (int i = 0; i < list2.Count; i++)
        {
            bool is_common = false;
            for (int j = 0; j < list1.Count; j++)
            {
                if (list2[i] == list1[j])
                {
                    is_common = true;
                    break;
                }
            }
            if (is_common == false)
                uncommonSet.Add(list2[i]);
        }
        List<int> uncommonList = new List<int>(uncommonSet);
        return uncommonList;

    }
}
