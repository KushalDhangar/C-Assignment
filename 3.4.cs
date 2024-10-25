using System;

public class Employee
{
    public string Name { get; set; }
    private int age;
    private decimal salary;
    public string Department { get; set; }

    public int Age
    {
        get { return age; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Age must be a positive value.");
            age = value;
        }
    }

    public decimal Salary
    {
        get { return salary; }
        private set
        {
            if (value < 0)
                throw new ArgumentException("Salary cannot be negative.");
            salary = value;
        }
    }

    public Employee(string name, int age, decimal salary, string department)
    {
        Name = name;
        Age = age;
        Salary = salary;
        Department = department;
    }

    public void DisplayEmployeeInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Salary: {Salary}, Department: {Department}");
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Employee emp = new Employee("Alice", 30, 5000, "Finance");
            emp.DisplayEmployeeInfo();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
