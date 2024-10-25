using System;

public class Storage<T>
{
    public T Item { get; set; }

    public Storage(T item)
    {
        Item = item;
    }
}

class Program
{
    static void Main()
    {
        Storage<int> intStorage = new Storage<int>(42);
        Console.WriteLine($"Integer Storage: {intStorage.Item}");

        Storage<string> stringStorage = new Storage<string>("Hello, Generics!");
        Console.WriteLine($"String Storage: {stringStorage.Item}");

        Storage<double> doubleStorage = new Storage<double>(3.14);
        Console.WriteLine($"Double Storage: {doubleStorage.Item}");
    }
}
