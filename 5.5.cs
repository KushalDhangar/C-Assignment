using System;

public abstract class Shape
{
    protected double Area { get; set; }

    public abstract void CalculateArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override void CalculateArea()
    {
        Area = Math.PI * Radius * Radius;
        Console.WriteLine($"Circle Area: {Area}");
    }
}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public override void CalculateArea()
    {
        Area = Length * Width;
        Console.WriteLine($"Rectangle Area: {Area}");
    }
}

class Program
{
    static void Main()
    {
        Circle circle = new Circle { Radius = 5 };
        circle.CalculateArea();

        Rectangle rectangle = new Rectangle { Length = 4, Width = 6 };
        rectangle.CalculateArea();
    }
}
