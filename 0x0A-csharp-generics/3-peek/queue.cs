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
    public Type CheckType()
    {
        return this.GetType();
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
}
