using Movers_Booking_System.Models;
using Movers_Booking_System.Tools;

namespace Movers_Booking_System.Controllers;

public class EstimateController
{
    private static string errorMessage = string.Empty;
    public static double CalculateEstimateCost(Job job)
    {
        return CalculateEstimateCost(job.NoRooms, job.IsApartment, job.NoBoxes, job.SelfPacked, job.FurnitureAssembly, job.SpecialItems, DateTool.IsPublicHolidayOrSunday(job.JobDate));
    }
    public static double CalculateEstimateCost(int noRooms, bool isApartment, int noBoxes, bool selfPacked, bool furnitureAssembly, List<SpecialItem> specialItems, bool isHoliday)
    {
        double price = 0;
        switch (noRooms)
        {
            case 1:
                if (isApartment) price += 300;
                else price += 370;
                break;
            case 2:
                if (isApartment) price += 550;
                else price += 590;
                break;
            case 3:
                price += 820;
                break;
            case 4:
                price += 1065;
                break;
        }

        double boxes = Math.Ceiling((double)(noBoxes / 10));
        price += boxes * 15;

        if (!selfPacked) price += 250;
        if (furnitureAssembly) price += 250;
        if (isHoliday) price += 200;
        foreach (SpecialItem s in specialItems) price += s.Price;

        return price;
    }
    public static bool VerifyEstimateDate(DateTime date, int noWorkers, int[] vans, int[] originalVans)
    {
        if (DateTool.IsNonNegotiableHoliday(date))
        {
            errorMessage = "Date is a non-negotiable holiday";
            return false;
        }
        if (DateTool.IsPublicHolidayOrSunday(date))
        {
            errorMessage = "Date is a public holiday and will incur a cost of £200\nDo you wish to continue?";
            return false;
        }
        if ((40 - DAL.GetWorkersOnDate(date)) < noWorkers)
        {
            errorMessage = "Not enough availabe workers on specified date";
            return false;
        }
        int[] vansOnDate = DAL.GetVansOnDate(date);
        if ((8 - vansOnDate[0])+originalVans[0] < vans[0])
        {
            errorMessage = "Not enough available small vans on specified date";
            return false;
        }
        if ((12 - vansOnDate[1])+originalVans[1] < vans[1])
        {
            errorMessage = "Not enough available medium vans on specified date";
            return false;
        }
        if ((10 - vansOnDate[2])+originalVans[2] < vans[2])
        {
            errorMessage = "Not enough available large vans on specified date";
            return false;
        }
        return true;
    }
    public static int CalculateTotalWorkers(int noRooms, List<SpecialItem> specialItems)
    {
        int totalWorkers = 0;
        if (noRooms >= 3) totalWorkers += 3;
        else totalWorkers += 2;
        foreach (SpecialItem s in specialItems) if (s.NoWorkers > totalWorkers) totalWorkers = s.NoWorkers;

        int[] vans = CalculateTotalVans(noRooms, specialItems);
        int sum = vans[0] + vans[1] + vans[2];
        if (sum > totalWorkers) totalWorkers = sum;
        return totalWorkers;
    }
    public static int[] CalculateTotalVans(int noRooms, List<SpecialItem> specialItems)
    {
        int[] vans = new int[3];
        if (noRooms >= 3) vans[2]++;
        else vans[1]++;

        foreach (SpecialItem s in specialItems) vans[0]++;
        return vans;
    }
    public static string ReadErrorMessage()
    {
        string msg = errorMessage;
        errorMessage = string.Empty;
        return msg;
    }
    public static string GenerateNewJobID()
    {
        List<string> idList = DAL.GetIDFromTable("Job");
        List<int> idValues = new List<int>();
        foreach (string id in idList) idValues.Add(Convert.ToInt32(id.Substring(2)));
        int max = 0;
        foreach (int i in idValues) if (i > max) max = i;
        int newIDValue = max + 1;
        string newID = "J-";
        if (newIDValue.ToString().Length == 1) newID += "00";
        else if (newIDValue.ToString().Length == 2) newID += "0";
        newID += newIDValue.ToString();
        return newID;
    }
    public static string[] GenerateInvoiceList(Job job)
    {
        List<string> names = new List<string>();
        List<string> costs = new List<string>();
        bool isHoliday = DateTool.IsPublicHolidayOrSunday(job.JobDate);

        switch (job.NoRooms)
        {
            case 1:
                if (job.IsApartment)
                {
                    costs.Add("£300");
                    names.Add("1 Bedroom Apartment");
                }
                else
                {
                    costs.Add("£370");
                    names.Add("1 Bedroom House");
                }
                break;
            case 2:
                if (job.IsApartment)
                {
                    costs.Add("£550");
                    names.Add("2 Bedroom Apartment");
                }
                else
                {
                    costs.Add("£590");
                    names.Add("2 Bedroom House");
                }
                break;
            case 3:
                costs.Add("£820");
                names.Add("3 Bedroom House");
                break;
            case 4:
                costs.Add("£1065");
                names.Add("4 Bedroom House");
                break;
        }

        double boxes = Math.Ceiling((double)(job.NoBoxes / 10));
        costs.Add("£" + (boxes * 15).ToString());
        names.Add($"Packing Boxes x{job.NoBoxes}");

        if (!job.SelfPacked)
        {
            costs.Add("£250");
            names.Add("Packing Service");
        }
        if (job.FurnitureAssembly)
        {
            costs.Add("£250");
            names.Add("Furniture Reassembly Service");
        }
        if (isHoliday)
        {
            costs.Add("200");
            names.Add("Holiday Fee");
        }
        costs.Add("");
        names.Add("Special Items:");

        List<string> uniqueItemNames = new List<string>();
        List<int> itemQuantities = new List<int>();

        for (int i = 0; i < job.SpecialItems.Count; i++)
        {
            if (!uniqueItemNames.Contains(job.SpecialItems[i].Name))
            {
                int quantity = 0;
                foreach (SpecialItem s in job.SpecialItems) if (s.Name == job.SpecialItems[i].Name) quantity++;
                uniqueItemNames.Add(job.SpecialItems[i].Name);
                itemQuantities.Add(quantity);
                costs.Add("£" + (job.SpecialItems[i].Price * quantity).ToString());
                names.Add($"    {job.SpecialItems[i].Name} x{quantity}");
            }
        }

        string namesString = "";
        string costsString = "";
        foreach (string name in names) namesString += $"{name}\n";
        foreach (string cost in costs) costsString += $"{cost}\n";
        return [namesString, costsString];
    }
}
