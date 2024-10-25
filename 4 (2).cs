using System;

public class Pair<T1, T2>
{
    public T1 First { get; set; }
    public T2 Second { get; set; }

    public Pair(T1 first, T2 second)
    {
        First = first;
        Second = second;
    }

    public void PrintPair()
    {
        Console.WriteLine($"Pair: {First}, {Second}");
    }
}

class Program
{
    static void Main()
    {
        Pair<int, string> intStringPair = new Pair<int, string>(1, "One");
        intStringPair.PrintPair();

        Pair<string, double> stringDoublePair = new Pair<string, double>("Pi", 3.1415);
        stringDoublePair.PrintPair();
    }
}
