using System;

public abstract class Appliance
{
    private int power;
    public int Power
    {
        get { return power; }
        set
        {
            if (value > 1000)
                throw new ArgumentOutOfRangeException("Power cannot exceed 1000 watts.");
            power = value;
        }
    }

    public abstract void TurnOn();
}

public class Fan : Appliance
{
    public override void TurnOn()
    {
        Console.WriteLine("Fan is turned on.");
    }
}

public class AirConditioner : Appliance
{
    public override void TurnOn()
    {
        Console.WriteLine("Air Conditioner is turned on.");
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Fan fan = new Fan();
            fan.Power = 500;
            fan.TurnOn();

            AirConditioner ac = new AirConditioner();
            ac.Power = 1200; // This will throw an exception
            ac.TurnOn();
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
