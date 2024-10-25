using System;

class PrimeChecker
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        
        try
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 1)
                throw new ArgumentException("The number must be a positive integer.");

            bool isPrime = true;
            if (number == 1)
                isPrime = false;
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            Console.WriteLine(isPrime ? $"{number} is a prime number." : $"{number} is not a prime number.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
