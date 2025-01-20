namespace Movers_Booking_System.Models;
public class Inspection
{
    public string ID { get; set; }
    public string CustomerID { get; set; }
    public string OldAddress { get; set; }
    public string NewAddress { get; set; }
    public DateTime Date { get; set; }
    public bool Paid { get; set; }
    public Inspection(string id, string customerID, string oldAddress, string newAddress, DateTime date, bool paid)
    {
        ID = id;
        CustomerID = customerID;
        OldAddress = oldAddress;
        NewAddress = newAddress;
        Date = date;
        Paid = paid;
    }
}
