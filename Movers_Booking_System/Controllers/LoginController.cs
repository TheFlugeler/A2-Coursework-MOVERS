using Movers_Booking_System.Models;
using Movers_Booking_System.Tools;

namespace Movers_Booking_System.Controllers;

public static class LoginController
{
    public static bool ValidateLoginDetails(string username, string password)
    {
        Staff? staff = DAL.GetStaffDetails(username);
        if (staff == null) return false;
        return EncryptTool.ComparePassword(staff, password);
    }
}
