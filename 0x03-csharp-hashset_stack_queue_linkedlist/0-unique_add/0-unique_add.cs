using System.Collections.Generic;
using System.Linq;

class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> uniqList = new HashSet<int>();

        for (int i = 0; i < myList.Count; i++)
        {
            uniqList.Add(myList[i]);
        }
        return uniqList.Sum();
    }
}
