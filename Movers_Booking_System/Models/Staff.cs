namespace Movers_Booking_System.Models;

public class Staff
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Salt { get; set; }
    public string Forename { get; set; }
    public string Surname { get; set; }
    public Staff(string username, string password, string salt, string forename, string surname)
    {
        Username = username;
        Password = password;
        Salt = salt;
        Forename = forename;
        Surname = surname;
    }
    public Staff()
    {
        Username = string.Empty;
        Password = string.Empty;
        Salt = string.Empty;
        Forename = string.Empty;
        Surname = string.Empty;
    }
}
