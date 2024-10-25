using System;
using System.IO;

public delegate void ProcessData(string data);

class Program
{
    static void DisplayData(string data)
    {
        Console.WriteLine($"Displaying Data: {data}");
    }

    static void LogData(string data)
    {
        File.WriteAllText("log.txt", data);
        Console.WriteLine("Data logged to file.");
    }

    static void Main()
    {
        ProcessData processData = DisplayData;
        processData += LogData;

        processData("Sample data");
    }
}
