using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aQueue.Count}");
        try
        {
            Console.WriteLine($"First item: {aQueue.Peek()}");
        }
        catch
        {
            Console.WriteLine($"Queue is empty");
        }
        if (newItem != null)
            aQueue.Enqueue(newItem);
        Console.WriteLine($"Queue contains {search}: {aQueue.Contains(search)}");
        if (aQueue.Contains(search))
        {
            bool is_search = false;
            while (is_search == false)
            {
                if (aQueue.Peek() == search)
                    is_search = true;
                aQueue.Dequeue();
            }
        }
        return aQueue;
    }
}
