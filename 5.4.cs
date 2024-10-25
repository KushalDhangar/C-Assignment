using System;

public class Person
{
    private int age;

    public string Name { get; set; }

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0 || value > 100)
                throw new ArgumentOutOfRangeException("Age must be between 0 and 100.");
            age = value;
        }
    }
}

public class Employee : Person
{
    private double salary;
    public double Salary
    {
        get { return salary; }
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Salary cannot be negative.");
            salary = value;
        }
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Salary: {Salary}");
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Employee emp = new Employee { Name = "John" };
            emp.Age = 150;  // Invalid Age
            emp.Salary = 50000;
            emp.DisplayDetails();
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
