using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int navIndex = 0;
        LinkedListNode<int> navigator = myLList.First;
        while (navigator != null)
        {
            if (navIndex == n)
                return navigator.Value;
            navIndex++;
            navigator = navigator.Next;
        }
        return 0;
    }
}
