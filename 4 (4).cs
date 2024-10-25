using System;
using System.Collections.Generic;

public class Stack<T>
{
    private List<T> items = new List<T>();

    public void Push(T item)
    {
        items.Add(item);
    }

    public T Pop()
    {
        if (items.Count == 0) throw new InvalidOperationException("Stack is empty.");
        T item = items[^1];
        items.RemoveAt(items.Count - 1);
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
        Stack<int> stack = new Stack<int>();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine("Element at index 0: " + stack[0]);
        Console.WriteLine("Element at index 2 (Top): " + stack[2]);
    }
}
