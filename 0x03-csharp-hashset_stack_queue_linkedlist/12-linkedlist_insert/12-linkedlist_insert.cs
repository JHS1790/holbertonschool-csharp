using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> navigator = myLList.First;
        while (navigator != null)
        {
            if (navigator.Next != null)
            {
                if ((n >= navigator.Value) && (n < navigator.Next.Value))
                {
                    myLList.AddBefore(navigator, n);
                    return navigator.Previous;
                }
            }
            navigator = navigator.Next;
        }
        myLList.AddLast(n);
        return myLList.Last;
    }
}
