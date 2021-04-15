using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int navIndex = 0;
        LinkedListNode<int> navigator = myLList.First;
        while (navigator != null)
        {
            if (navigator.Value == value)
                return navIndex;
            navIndex++;
            navigator = navigator.Next;
        }
        return -1;
    }
}
