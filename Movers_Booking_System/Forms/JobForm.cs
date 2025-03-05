using Movers_Booking_System.Controllers;
using Movers_Booking_System.Models;
using Movers_Booking_System.Tools;

namespace Movers_Booking_System.Forms;

public partial class JobForm : Form
{
    private Job selectedJob;
    private List<Job> jobList = new();
    public JobForm()
    {
        InitializeComponent();
        FillEstimateList();
        if (jobList.Count > 0) selectedJob = jobList[0];
    }
    private void FillEstimateList()
    {
        List<Job> allJobs = DAL.GetJobsList();
        foreach (Job j in allJobs) if (!j.Confirmed) jobList.Add(j);
        List<string> jobNames = new();
        foreach (Job job in jobList) jobNames.Add($"{job.ID} - {job.CustomerID} - {job.JobDate}");
        comboBoxEstimate.DataSource = jobNames;
    }
    private void buttonBack_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new MainForm());
    private void comboBoxEstimate_SelectedIndexChanged(object sender, EventArgs e) => textBoxPrice.Text = $"£{jobList[comboBoxEstimate.SelectedIndex].Price}";
    private void customButtonSubmit_Click(object sender, EventArgs e)
    {
        if (comboBoxEstimate.SelectedIndex < 0)
        {
            MessageBox.Show("Invalid Estimate Selected", "Error");
            return;
        }
        if (!double.TryParse(textBox1.Text, out double amountPaid))
        {
            MessageBox.Show("Amount Paid has an invalid format", "Error");
            return;
        }
        selectedJob.AmountPaid = amountPaid;
        selectedJob.Confirmed = checkBoxConfirmed.Checked;
        if (JobController.ConvertJob(selectedJob))
        {
            MessageBox.Show("Job Converted Successfully");
            DisplayController.DisplayForm(new MainForm());
        }
        else MessageBox.Show(JobController.ReadErrorMessage(), "Error");
    }
}