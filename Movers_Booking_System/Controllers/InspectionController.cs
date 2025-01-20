using Movers_Booking_System.Models;
using Movers_Booking_System.Tools;

namespace Movers_Booking_System.Controllers;

public static class InspectionController
{
    private static string errorMessage = "";
    public static bool ValidateNewInspectionDate(DateTime date, string id)
    {
        if (id != "") if (DAL.GetInspectionDate(id).Day == date.Day) return true;
        if (DateTool.IsPublicHolidayOrSunday(date))
        {
            errorMessage = "Selected date is a public holiday or a Sunday";
            return false;
        }
        if (date < DateTime.Today) return false;

        if (DAL.GetMatchingInspectionDates(date) >= 2)
        {
            errorMessage = "Selected date has no free inspection slots";
            return false;
        }
        return true;
    }
    public static string ReadErrorMessage()
    {
        string msg = errorMessage;
        errorMessage = "";
        return msg;
    }
    public static string GenerateNewInspectionID()
    {
        List<string> idList = DAL.GetIDFromTable("Inspection");
        List<int> idValues = new List<int>();
        foreach (string id in idList) idValues.Add(Convert.ToInt32(id.Substring(2)));
        int max = 0;
        foreach (int i in idValues) if (i > max) max = i;
        int newIDValue = max + 1;
        string newID = "I-";
        if (newIDValue.ToString().Length == 1) newID += "00";
        else if (newIDValue.ToString().Length == 2) newID += "0";
        newID += newIDValue.ToString();
        return newID;
    }

    public static string GetDateSummary(DateTime date)
    {
        List<Inspection> inspections = DAL.GetInspectionsOnDate(date);
        string totalSummary = "";
        foreach (Inspection i in inspections) totalSummary += GetInspectionSummary(i);
        return totalSummary;
    }

    private static string GetInspectionSummary(Inspection insp)
    {
        string summary = $"Inspection ID - {insp.ID}\nCustomer ID - {insp.CustomerID}\n" +
            $"Old Address - {insp.OldAddress}\nNew Address - {insp.NewAddress}\n\n\n";
        return summary;
    }
    public static string[] GenerateInvoiceList(Inspection insp) => ["House Inspection", "£20"];
}
