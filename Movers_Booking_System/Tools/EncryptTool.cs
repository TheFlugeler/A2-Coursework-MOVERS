using Movers_Booking_System.Models;
using System.Security.Cryptography;
using System.Text;

namespace Movers_Booking_System.Tools;

public static class EncryptTool
{
    public static List<string> HashPassword(string password)
    {
        string salt = GenerateSalt();
        string combinedString = $"{password}:{salt}";

        byte[] inputBytes = Encoding.UTF8.GetBytes(combinedString);
        byte[] hashedBytes = SHA256.Create().ComputeHash(inputBytes);

        string hashString = Convert.ToBase64String(hashedBytes);
        return new List<string>() { hashString, salt };
    }

    private static string GenerateSalt()
    {
        int saltLength = 32;
        var bytes = new byte[saltLength];
        bytes = RandomNumberGenerator.GetBytes(saltLength);
        string salt = Convert.ToBase64String(bytes);
        return salt;
    }
    public static bool ComparePassword(Staff staff, string password)
    {
        string combinedString = $"{password}:{staff.Salt}";

        byte[] inputBytes = Encoding.UTF8.GetBytes(combinedString);
        byte[] hashedBytes = SHA256.Create().ComputeHash(inputBytes);

        string hashString = Convert.ToBase64String(hashedBytes);

        return hashString == staff.Password;
    }
}
