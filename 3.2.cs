using System;

class StudentGrade
{
    static void Main()
    {
        int[] marks = new int[5];
        Console.WriteLine("Enter marks for five subjects (0-100):");

        for (int i = 0; i < 5; i++)
        {
            try
            {
                Console.Write($"Subject {i + 1}: ");
                marks[i] = int.Parse(Console.ReadLine());

                if (marks[i] < 0 || marks[i] > 100)
                    throw new ArgumentOutOfRangeException("Marks must be between 0 and 100.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a numeric value.");
                i--;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                i--;
            }
        }

        int total = 0;
        foreach (int mark in marks)
            total += mark;

        double average = total / 5.0;
        char grade;

        if (average >= 90) grade = 'A';
        else if (average >= 80) grade = 'B';
        else if (average >= 70) grade = 'C';
        else if (average >= 60) grade = 'D';
        else grade = 'F';

        Console.WriteLine($"Average: {average:F2}, Grade: {grade}");
    }
}
