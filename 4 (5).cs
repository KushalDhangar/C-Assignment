using System;
using System.Collections.Generic;

public class Queue<T>
{
    private List<T> items = new List<T>();

    public void Enqueue(T item)
    {
        items.Add(item);
    }

    public T Dequeue()
    {
        if (items.Count == 0) throw new InvalidOperationException("Queue is empty.");
        T item = items[0];
        items.RemoveAt(0);
        return item;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= items.Count) throw new IndexOutOfRangeException("Invalid index.");
            return items[index];
        }
    }
}

class Program
{
    static void Main()
    {
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");

        Console.WriteLine("Element at index 0 (First): " + queue[0]);
        Console.WriteLine("Element at index 2 (Last): " + queue[2]);
    }
}
