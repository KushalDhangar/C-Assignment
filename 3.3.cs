using System;

public class TemperatureConverter
{
    private double celsius;
    private double fahrenheit;

    public double Celsius
    {
        get { return celsius; }
        set
        {
            celsius = value;
            fahrenheit = (celsius * 9 / 5) + 32;
        }
    }

    public double Fahrenheit
    {
        get { return fahrenheit; }
        set
        {
            fahrenheit = value;
            celsius = (fahrenheit - 32) * 5 / 9;
        }
    }

    public void ConvertTemperature()
    {
        Console.WriteLine("Choose conversion: 1) Celsius to Fahrenheit 2) Fahrenheit to Celsius");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Enter temperature in Celsius: ");
            Celsius = double.Parse(Console.ReadLine());
            Console.WriteLine($"Temperature in Fahrenheit: {Fahrenheit:F2}");
        }
        else if (choice == 2)
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            Fahrenheit = double.Parse(Console.ReadLine());
            Console.WriteLine($"Temperature in Celsius: {Celsius:F2}");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }
}

class Program
{
    static void Main()
    {
        TemperatureConverter converter = new TemperatureConverter();

        while (true)
        {
            converter.ConvertTemperature();
            Console.WriteLine("Do you want to perform another conversion? (yes/no)");
            string response = Console.ReadLine();

            if (response.ToLower() != "yes")
                break;
        }
    }
}
