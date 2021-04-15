using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        int delValue = myLList.First.Value;
        myLList.RemoveFirst();
        return delValue;
    }
}
