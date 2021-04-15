using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> navigator = myLList.First;
        for (int i = 0; i < index; i++)
            navigator = navigator.Next;
        myLList.Remove(navigator.Value);
    }
}
