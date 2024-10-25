using System;

public class MovieTicket
{
    public string MovieName { get; set; }
    public DateTime ShowTime { get; set; }
    public int SeatNumber { get; private set; }
    public decimal TicketPrice { get; set; }
    private bool isBooked;

    public MovieTicket(string movieName, DateTime showTime, int seatNumber, decimal ticketPrice)
    {
        MovieName = movieName;
        ShowTime = showTime;
        SeatNumber = seatNumber;
        TicketPrice = ticketPrice;
        isBooked = false;
    }

    public void BookTicket()
    {
        if (isBooked)
            throw new InvalidOperationException("Seat already booked.");

        isBooked = true;
        decimal finalPrice = TicketPrice > 50 ? TicketPrice * 0.9m : TicketPrice; // 10% discount for tickets above $50
        Console.WriteLine($"Ticket booked for '{MovieName}' at {ShowTime}. Seat: {SeatNumber}, Price: ${finalPrice}");
    }

    public void DisplayTicketDetails()
    {
        Console.WriteLine($"Movie: {MovieName}, Show Time: {ShowTime}, Seat: {SeatNumber}, Price: ${TicketPrice}");
    }
}

class Program
{
    static void Main()
    {
        MovieTicket ticket = new MovieTicket("Inception", new DateTime(2023, 12, 5, 18, 30, 0), 12, 60);

        try
        {
            ticket.BookTicket();
            ticket.DisplayTicketDetails();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
