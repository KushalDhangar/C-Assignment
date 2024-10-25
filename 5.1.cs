using System;

public delegate int MathOperation(int a, int b);

class Program
{
    static int Add(int a, int b) => a + b;

    static void Main()
    {
        MathOperation mathOp = Add;
        int result = mathOp(5, 10);
        Console.WriteLine($"Sum: {result}");
    }
}
