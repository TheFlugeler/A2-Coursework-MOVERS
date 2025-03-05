using Movers_Booking_System.Controllers;
using Movers_Booking_System.Models;
using Movers_Booking_System.Tools;

namespace Movers_Booking_System.Forms;

public partial class PrintForm : Form
{
    private bool isJobInvoice;
    private List<Job> jobs;
    private List<Inspection> inspections;
    private Font font = new Font("Bahnschrift", 15);
    private Brush brush = Brushes.Black;
    public PrintForm(bool isJob)
    {
        InitializeComponent();
        isJobInvoice = isJob;
        if (isJob)
        {
            labelPrint.Text = "Print Job Invoice";
            labelRecord.Text = "Job";
            jobs = DAL.GetJobsList();
            List<string> strings = new List<string>();
            foreach (Job j in jobs) strings.Add($"{j.ID} - {j.CustomerID} - {j.JobDate.ToShortDateString()}");
            comboBox1.DataSource = strings;
            labelSelectRecord.Text = "Select Job to Print";
        }
        else
        {
            labelPrint.Text = "Print Inspection Invoice";
            labelRecord.Text = "Inspection";
            inspections = DAL.GetInspectionsList();
            List<string> strings = new List<string>();
            foreach (Inspection i in inspections) strings.Add($"{i.ID} - {i.CustomerID} - {i.Date.ToShortDateString()}");
            comboBox1.DataSource = strings;
            labelSelectRecord.Text = "Select Inspection to Print";
        }
        labelRecord.Location = new Point(labelPrice.Right - labelRecord.Width, labelRecord.Location.Y);
    }

    private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
        string[] itemisedList;
        string totalCost;
        if (isJobInvoice)
        {
            PrintController.DrawInvoiceHeader(sender, e, jobs[comboBox1.SelectedIndex]);
            itemisedList = JobController.GenerateInvoiceList(jobs[comboBox1.SelectedIndex]);
            totalCost = "£" + JobController.CalculateEstimateCost(jobs[comboBox1.SelectedIndex]).ToString();
        }else
        {
            PrintController.DrawInvoiceHeader(sender, e, inspections[comboBox1.SelectedIndex]);
            itemisedList = ["House Inspection", "£20"];
            totalCost = "£20";
        }
        PrintController.DrawItemList(sender, e, itemisedList, totalCost);
        PrintController.DrawInvoiceFooter(sender, e);
    }
    private void customButtonPrint_Click(object sender, EventArgs e)
    {
        if (comboBox1.SelectedIndex < 0)
        {
            MessageBox.Show("Please select a record", "Error");
            return;
        }
        printPreviewDialog.Document = printDocument;
        printDocument.DefaultPageSettings.PaperSize = new("PaperA4", 826, 1169);
        printPreviewDialog.ShowDialog();
    }
    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (isJobInvoice) textBox1.Text = jobs[comboBox1.SelectedIndex].Price.ToString();
        else textBox1.Text = "20";        
    }
    private void buttonBack_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new MainForm());
}
