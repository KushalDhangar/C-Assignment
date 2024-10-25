using System;

public class Calculator<T> where T : struct, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
{
    public T Add(T a, T b) => (dynamic)a + (dynamic)b;
    public T Subtract(T a, T b) => (dynamic)a - (dynamic)b;
    public T Multiply(T a, T b) => (dynamic)a * (dynamic)b;
    public T Divide(T a, T b)
    {
        if ((dynamic)b == 0) throw new DivideByZeroException("Cannot divide by zero.");
        return (dynamic)a / (dynamic)b;
    }
}

class Program
{
    static void Main()
    {
        Calculator<int> intCalculator = new Calculator<int>();
        Console.WriteLine("Integer Addition: " + intCalculator.Add(10, 20));
        Console.WriteLine("Integer Division: " + intCalculator.Divide(10, 2));

        Calculator<double> doubleCalculator = new Calculator<double>();
        Console.WriteLine("Double Multiplication: " + doubleCalculator.Multiply(2.5, 4.0));
        Console.WriteLine("Double Subtraction: " + doubleCalculator.Subtract(5.5, 1.5));
    }
}
