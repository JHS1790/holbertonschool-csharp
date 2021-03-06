using System;


class Queue<T>
{
    Node head;
    Node tail;
    int count;
    public class Node
    {
        public T value = default(T);
        public Node next = null;

        public Node(T newValue)
        {
            this.value = newValue;
        }
    }
    public string CheckType()
    {
        return typeof(T).ToString();
    }
    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }
        if (!(head.value is char) && !(head.value is string))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }
        string concatString = "";
        Node navigator = head;
        for (int i = 0; i < count; i++)
        {
            concatString += navigator.value;
            navigator = navigator.next;
            if (head.value is string)
                concatString += ' ';
        }
        return concatString;
    }
    public int Count()
    {
        return count;
    }
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        Node dequeuer = head;
        head = head.next;
        count--;
        return dequeuer.value;
    }
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if(head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }
        count++;
    }
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        return head.value;
    }
    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
        }
        Node navigator = head;
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(navigator.value);
            navigator = navigator.next;
        }
    }
}
