using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        int listSum = 0;
        LinkedListNode<int> navigator = myLList.First;
        while (navigator != null)
        {
            listSum += navigator.Value;
            navigator = navigator.Next;
        }
        return listSum;
    }
}
