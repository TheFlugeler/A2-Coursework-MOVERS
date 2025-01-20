namespace Movers_Booking_System.Models;

public class SpecialItem
{
    public string Name { get; set; }
    public int NoWorkers { get; set; }
    public double Price { get; set; }
    public SpecialItem(string name, int noWorkers, double price)
    {
        Name = name;
        NoWorkers = noWorkers;
        Price = price;
    }
}
