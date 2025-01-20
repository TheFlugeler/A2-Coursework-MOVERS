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
    private void comboBoxEstimate_SelectedIndexChanged(object sender, EventArgs e)
    {
        selectedJob = jobList[comboBoxEstimate.SelectedIndex];
        textBoxPrice.Text = $"£{selectedJob.Price}";
    }
    private void customButtonSubmit_Click(object sender, EventArgs e)
    {
        if (!checkBoxConfirmed.Checked)
        {
            MessageBox.Show("Estimate must be confirmed before it is converted into a job");
            return;
        }
        double amountPaid;
        if (!double.TryParse(textBox1.Text, out amountPaid))
        {
            MessageBox.Show("Amount Paid has an invalid format", "Error");
            return;
        }
        if (amountPaid < (Convert.ToDouble(textBoxPrice.Text.Substring(1)) / 2))
        {
            MessageBox.Show("Amount paid must be at least the 50% deposit");
            return;
        }

        selectedJob.Confirmed = true;
        selectedJob.AmountPaid = Convert.ToDouble(textBox1.Text);
        DAL.UpdateJob(selectedJob);
        MessageBox.Show("Job successfully converted", "Success");
        DisplayController.DisplayForm(new MainForm());
    }
}
