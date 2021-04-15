using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int count = 0;
        LinkedListNode<int> navigator = myLList.First;
        while (navigator != null)
        {
            count++;
            navigator = navigator.Next;
        }
        return count;
    }
}
