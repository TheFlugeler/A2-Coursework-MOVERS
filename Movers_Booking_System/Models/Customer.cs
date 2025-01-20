namespace Movers_Booking_System.Models;
public class Customer
{
    public string ID { get; set; }
    public string Forename { get; set; }
    public string Surname { get; set; }
    public string TelNo { get; set; }
    public string Email { get; set; }
    public Customer(string id, string forename, string surname, string telNo, string email)
    {
        ID = id;
        Forename = forename;
        Surname = surname;
        TelNo = telNo;
        Email = email;
    }
}
