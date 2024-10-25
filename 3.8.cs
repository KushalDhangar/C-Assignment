using System;

public class Car
{
    public string Model { get; set; }
    public decimal DailyRate { get; set; }
    public bool IsAvailable { get; private set; } = true;

    public Car(string model, decimal dailyRate)
    {
        Model = model;
        DailyRate = dailyRate;
    }

    public decimal RentCar(int rentalDays)
    {
        if (!IsAvailable)
            throw new InvalidOperationException("Car is not available for rental.");

        IsAvailable = false;
        return rentalDays * DailyRate;
    }

    public void ReturnCar()
    {
        IsAvailable = true;
    }
}

class Program
{
    static void Main()
    {
        Car car = new Car("Toyota Camry", 50m);

        try
        {
            int rentalDays = 3;
            decimal totalCost = car.RentCar(rentalDays);
            Console.WriteLine($"Car rented successfully. Total cost for {rentalDays} days: ${totalCost}");
            car.ReturnCar();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
