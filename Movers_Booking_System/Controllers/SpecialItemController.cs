using Movers_Booking_System.Models;
using Movers_Booking_System.Tools;

namespace Movers_Booking_System.Controllers;

public class SpecialItemController
{
    private static string errorMessage = string.Empty;
    public static bool ValidateSpecialItem(string price, string name, string originalName)
    {
        if (!double.TryParse(price, out double specialItemPrice))
        {
            errorMessage = "Price is not in valid format";
            return false;
        }
        if (specialItemPrice < 0)
        {
            errorMessage = "Price is not in valid range";
            return false;
        }
        List<string> names = GetSpecialItemNames();
        foreach (string n in names) if (n == name && name != originalName)
            {
                errorMessage = "Name is already registered";
                return false;
            }
        return true;
    }
    public static SpecialItem GetSpecialItem(int i)
    {
        List<SpecialItem> items = DAL.GetSpecialItemsList();
        return items[i];
    }
    public static List<string> GetSpecialItemNames()
    {
        List<SpecialItem> specialItems = DAL.GetSpecialItemsList();
        List<string> names = new List<string>();
        foreach (SpecialItem item in specialItems) names.Add(item.Name);
        return names;
    }
    public static string ReadErrorMessage()
    {
        string msg = errorMessage;
        errorMessage = string.Empty;
        return msg;
    }
}
