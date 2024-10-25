using System;

public class Order
{
    public int OrderID { get; private set; }
    public string CustomerName { get; set; }
    public decimal Amount { get; set; }
    private string orderStatus;

    public string OrderStatus
    {
        get { return orderStatus; }
        private set { orderStatus = value; }
    }

    public Order(int orderId, string customerName, decimal amount)
    {
        OrderID = orderId;
        CustomerName = customerName;
        Amount = amount;
        OrderStatus = "Placed";
    }

    public void UpdateOrderStatus(string status)
    {
        switch (status.ToLower())
        {
            case "placed":
            case "shipped":
            case "delivered":
                OrderStatus = status;
                break;
            default:
                Console.WriteLine("Invalid status. Status not updated.");
                break;
        }
    }

    public void DisplayOrderDetails()
    {
        Console.WriteLine($"OrderID: {OrderID}, Customer: {CustomerName}, Amount: {Amount}, Status: {OrderStatus}");
    }
}

class Program
{
    static void Main()
    {
        Order order = new Order(1, "John Doe", 150.75m);
        order.DisplayOrderDetails();

        order.UpdateOrderStatus("Shipped");
        order.DisplayOrderDetails();
    }
}
