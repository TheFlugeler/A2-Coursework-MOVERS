using Movers_Booking_System.Controllers;
using Movers_Booking_System.Models;
using Movers_Booking_System.Tools;

namespace Movers_Booking_System.Forms;

public partial class MessagesForm : Form
{
    private List<Job> outdatedEstimates = new List<Job>();
    private List<Job> pastJobs = new List<Job>();
    public MessagesForm()
    {
        InitializeComponent();
        panelList.Visible = false;
        customButtonDelete.Visible = false;
        List<Job> jobs = DAL.GetJobsList();
        foreach (Job j in jobs)
        {
            if (j.Confirmed && j.JobDate < DateTime.Today) pastJobs.Add(j);
            if (!j.Confirmed && j.EstimateDate < DateTime.Today.AddDays(-4)) outdatedEstimates.Add(j);
        }
        labelEstimates.Text += outdatedEstimates.Count.ToString();
        labelJobs.Text += pastJobs.Count.ToString();
    }
    private void buttonEstimate_Click(object sender, EventArgs e)
    {
        panelList.Visible = true;
        customButtonDelete.Visible = true;
        panelMessages.Visible = false;
        labelSelectedMessage.Text = "Delete all outdated estimates?";
        dataGridView.DataSource = outdatedEstimates;
    }
    private void buttonJob_Click(object sender, EventArgs e)
    {
        panelList.Visible = true;
        customButtonDelete.Visible = true;
        panelMessages.Visible = false;
        labelSelectedMessage.Text = "Delete all outdated jobs?";
        dataGridView.DataSource = pastJobs;
    }

    private void customButtonDelete_Click(object sender, EventArgs e)
    {
        DialogResult yn = MessageBox.Show("Are you sure you want to delete these items?", "Delete", MessageBoxButtons.YesNo);
        if (yn == DialogResult.No) return;
        JobController.DeleteJobList(dataGridView.DataSource as List<Job>);
        MessageBox.Show("Outdated records have been deleted", "Success");
        DisplayController.DisplayForm(new MainForm());
    }
    private void buttonBack_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new MainForm());
}
