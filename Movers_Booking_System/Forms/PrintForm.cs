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
        DrawHeader(sender, e);
        string[] itemisedList;
        string totalCost;
        if (isJobInvoice)
        {
            itemisedList = EstimateController.GenerateInvoiceList(jobs[comboBox1.SelectedIndex]);
            totalCost = "£" + EstimateController.CalculateEstimateCost(jobs[comboBox1.SelectedIndex]).ToString();
        }
        else
        {
            itemisedList = InspectionController.GenerateInvoiceList(inspections[comboBox1.SelectedIndex]);
            totalCost = "£20";
        }
        e.Graphics.DrawString(itemisedList[0], font, brush, new Point(20, 180));
        e.Graphics.DrawString(itemisedList[1], font, brush, new Point(670, 180));
        e.Graphics.DrawString("Total Cost", font, brush, new Point(20, 850));
        e.Graphics.DrawString(totalCost, font, brush, new Point(670, 850));
        e.Graphics.DrawLine(new Pen(brush, 4), new Point(0, 880), new Point(826, 880));
        DrawFooter(sender, e);
    }

    private void DrawHeader(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
        string heading;
        if (isJobInvoice)
        {
            heading = $"Customer: {jobs[comboBox1.SelectedIndex].CustomerID}\nMoval Date: {jobs[comboBox1.SelectedIndex].JobDate.ToShortDateString()}\nAddress: {jobs[comboBox1.SelectedIndex].OldAddress}";
        }
        else
        {
            heading = $"Customer: {inspections[comboBox1.SelectedIndex].CustomerID}\nInspection Date: {inspections[comboBox1.SelectedIndex].Date.ToShortDateString()}\nAddress: {inspections[comboBox1.SelectedIndex].OldAddress}";
        }
        Image img = Image.FromFile("Media/PrintLogo.png");
        e.Graphics.DrawImage(img, new Point(-30, -100));
        e.Graphics.DrawString("MOVERS - Moval Company", new Font("Bahnschrift", 20), Brushes.Black, new Point(297, 30));
        e.Graphics.DrawString(heading, font, Brushes.Black, new Point(300, 65));
        e.Graphics.DrawString($"{DateTime.Today.ToShortDateString()}", font, Brushes.Black, new Point(700, 35));
        e.Graphics.DrawLine(new Pen(brush, 4), new Point(0, 160), new Point(826, 160));
        img.Dispose();
    }

    private void DrawFooter(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
        e.Graphics.DrawString("Bank Transfer Details:\nAccount Name: MOVERS Company\nBank: Bank of Ireland\nSort Code: 00-00-00\nAccount Number: 12345678", font, brush, new Point(20, 900));
        e.Graphics.DrawString("Cheques Payable to: MOVERS Moval Company\nPlease put customer number on reverse", font, brush, new Point(370, 900));
    }

    private void buttonBack_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new MainForm());

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
        if (isJobInvoice)
        {
            textBox1.Text = jobs[comboBox1.SelectedIndex].Price.ToString();
        }
        else
        {
            textBox1.Text = "20";
        }
    }
}
