using Movers_Booking_System.Models;
using Movers_Booking_System.Tools;

namespace Movers_Booking_System.Controllers;

public class JobController
{
    private static string errorMessage = string.Empty;
    public static string ReadErrorMessage()
    {
        string msg = errorMessage;
        errorMessage = string.Empty;
        return msg;
    }
    public static double CalculateEstimateCost(Job job)
    {
        double price = 0;
        switch (job.NoRooms)
        {
            case 1:
                if (job.IsApartment) price += 300;
                else price += 370;
                break;
            case 2:
                if (job.IsApartment) price += 550;
                else price += 590;
                break;
            case 3:
                price += 820;
                break;
            case 4:
                price += 1065;
                break;
        }

        double boxes = Math.Ceiling((double)(job.NoBoxes / 10));
        price += boxes * 15;

        if (!job.SelfPacked) price += 250;
        if (job.FurnitureAssembly) price += 250;
        if (DateTool.IsPublicHolidayOrSunday(job.JobDate)) price += 200;
        foreach (SpecialItem s in job.SpecialItems) price += s.Price;

        return price;
    }
    public static bool VerifyEstimate(Job job, int noWorkers, int[] vans, int[] originalVans)
    {
        errorMessage = "";
        int[] vansOnDate = DAL.GetVansOnDate(job.JobDate);
        if (DateTool.IsNonNegotiableHoliday(job.JobDate)) errorMessage = "Date is a non-negotiable holiday";
        if (DateTool.IsPublicHolidayOrSunday(job.JobDate)) errorMessage = "Date is a public holiday and will incur a cost of £200\nDo you wish to continue?";
        if ((40 - DAL.GetWorkersOnDate(job.JobDate)) < noWorkers) errorMessage = "Not enough availabe workers on specified date";
        if ((8 - vansOnDate[0]) + originalVans[0] < vans[0]) errorMessage = "Not enough available small vans on specified date";
        if ((12 - vansOnDate[1]) + originalVans[1] < vans[1]) errorMessage = "Not enough available medium vans on specified date";
        if ((10 - vansOnDate[2]) + originalVans[2] < vans[2]) errorMessage = "Not enough available large vans on specified date";
        if (!ValidationTool.ContainsOnlyLettersNumbersAndPunctuation(job.NewAddress) ||
            !ValidationTool.ContainsOnlyLettersNumbersAndPunctuation(job.OldAddress)) 
            errorMessage = "Address is in invalid format";
        if (job.AmountPaid < 0) errorMessage = "Invalid Amount Paid";
        if (job.AmountPaid > job.Price) errorMessage = "Amount paid cannot be more than job price";

        if (errorMessage == "") return true;
        return false;
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
    public static string GenerateNewJobID()
    {
        List<string> idList = DAL.GetIDListFromTable("Job");
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

    public static bool WriteJob(Job job, bool edit, int[] originalVans)
    {
        int[] vans = CalculateTotalVans(job.NoRooms, job.SpecialItems);
        job.NoSmallVans = vans[0];
        job.NoMediumVans = vans[1];
        job.NoLargeVans = vans[2];
        int noWorkers = CalculateTotalWorkers(job.NoRooms, job.SpecialItems);
        job.NoWorkers = noWorkers;
        job.Price = CalculateEstimateCost(job);
        if (!VerifyEstimate(job, noWorkers, vans, originalVans))
        {
            if (errorMessage.Contains("200"))
            {
                DialogResult dr = MessageBox.Show(errorMessage, "Extra Cost", MessageBoxButtons.YesNo);
                if (dr == DialogResult.No) return false;
            }
            else return false;
        }

        

        if (edit)
        {
            if (DAL.UpdateJob(job) == 1) return true;
            else errorMessage = "Update Job Query Failed";
        }
        else
        {
            if (DAL.WriteNewJob(job) == 1) return true;
            else errorMessage = "Write New Job Query Failed";
        }
        return false;
    }
    public static bool ConvertJob(Job job)
    {
        errorMessage = "";
        if (!job.Confirmed)
        {
            errorMessage = "Job must be confirmed to convert";
            return false;
        }
        else if (job.AmountPaid < job.Price / 2)
        {
            errorMessage = "50% Deposit must be paid before converting";
            return false;
        }else if (job.AmountPaid > job.Price)
        {
            errorMessage = "Amount paid cannot be more than the job price";
            return false;
        }

        if (DAL.UpdateJob(job) == 1) return true;
        else
        {
            errorMessage = "Update Job Query Failed";
            return false;
        }
    }
    private static string GetJobSummary(Job job)
    {
        string summary = $"Job ID - {job.ID}\nCustomer ID - {job.CustomerID}\nOld Address - " +
            $"{job.OldAddress.ReplaceLineEndings(" ")}\nNew Address - {job.NewAddress.ReplaceLineEndings(" ")}\nNo. Workers - {job.NoWorkers}\nVans: Small - " +
            $"{job.NoSmallVans} Medium - {job.NoMediumVans} Large - {job.NoLargeVans}\n\n\n";
        return summary;
    }
    public static string GetDateSummary(DateTime date)
    {
        List<Job> allJobs = DAL.GetJobsOnDate(date);
        List<Job> jobs = new();
        foreach (Job j in allJobs) if (j.Confirmed) jobs.Add(j);
        string totalSummary = "";
        foreach (Job job in jobs) totalSummary += GetJobSummary(job);
        return totalSummary;
    }

    public static void DeleteJobList(List<Job> jobs)
    {
        foreach (Job job in jobs) DAL.DeleteRecord(job.ID, "Job");
    }
}
