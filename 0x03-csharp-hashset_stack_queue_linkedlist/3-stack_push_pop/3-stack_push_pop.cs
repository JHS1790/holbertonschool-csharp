using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aStack.Count}");
        try
        {
            Console.WriteLine($"Top item: {aStack.Peek()}");
        }
        catch
        {
            Console.WriteLine($"Stack is empty");
        }
        Console.WriteLine($"Stack contains {search}: {aStack.Contains(search)}");
        if (aStack.Contains(search))
        {
            bool is_search = false;
            while (is_search == false)
            {
                if (aStack.Peek() == search)
                    is_search = true;
                aStack.Pop();
            }
        }
        if (newItem != null)
            aStack.Push(newItem);
        return aStack;
    }
}
