using Movers_Booking_System.Models;
using Movers_Booking_System.Tools;

namespace Movers_Booking_System.Controllers;

public static class InspectionController
{
    private static string errorMessage = "";
    public static bool ValidateInspection(Inspection inspection)
    {
        if (inspection.ID != "") if (DAL.GetInspectionDate(inspection.ID).Day == inspection.Date.Day) return true;
        if (DateTool.IsPublicHolidayOrSunday(inspection.Date.Date))
        {
            errorMessage = "Selected date is a public holiday or a Sunday";
            return false;
        }
        if (inspection.Date.Date < DateTime.Today) return false;

        if (DAL.GetMatchingInspectionDates(inspection.Date.Date) >= 2)
        {
            errorMessage = "Selected date has no free inspection slots";
            return false;
        }

        if (!ValidationTool.ContainsOnlyLettersNumbersAndPunctuation(inspection.NewAddress)
            || !ValidationTool.ContainsOnlyLettersNumbersAndPunctuation(inspection.OldAddress))
        {
            errorMessage = "Address is in an invalid format";
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
        List<string> idList = DAL.GetIDListFromTable("Inspection");
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
        foreach (Inspection i in inspections) totalSummary += $"Inspection ID - {i.ID}\nCustomer ID - {i.CustomerID}\n" +
                $"Old Address - {i.OldAddress.ReplaceLineEndings(" ")}\nNew Address - {i.NewAddress.ReplaceLineEndings(" ")}\n\n\n";
        return totalSummary;
    }

    public static bool WriteInspection(Inspection inspection, bool editMode)
    {
        if (!ValidateInspection(inspection)) return false;
        if (editMode)
        {
            if (DAL.UpdateInspection(inspection) == 1) return true;
            else
            {
                errorMessage = "Update Inspection Query Failed";
                return false;
            }
        }
        else
        {
            if (DAL.WriteNewInspection(inspection) == 1) return true;
            else
            {
                errorMessage = "Write New Inspection Query Failed";
                return false;
            }
        }
    }
}
