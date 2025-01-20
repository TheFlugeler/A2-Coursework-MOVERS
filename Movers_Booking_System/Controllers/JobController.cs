using Movers_Booking_System.Models;
using Movers_Booking_System.Tools;

namespace Movers_Booking_System.Controllers;

public static  class JobController
{
    private static string GetJobSummary(Job job)
    {
        string summary = $"Job ID - {job.ID}\nCustomer ID - {job.CustomerID}\nOld Address - " +
            $"{job.OldAddress}\nNew Address - {job.NewAddress}\nNo. Workers - {job.NoWorkers}\nVans: Small - " +
            $"{job.NoSmallVans} Medium - {job.NoMediumVans} Large - {job.NoLargeVans}\n\n\n";
        return summary;
    }
    public static string GetDateSummary(DateTime date)
    {
        List<Job> allJobs = DAL.GetJobsOnDate(date);
        List<Job> jobs = new();
        foreach(Job j in allJobs) if(j.Confirmed) jobs.Add(j);
        string totalSummary = "";
        foreach (Job job in jobs) totalSummary += GetJobSummary(job);
        return totalSummary;
    }
}
