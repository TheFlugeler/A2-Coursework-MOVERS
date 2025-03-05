using Movers_Booking_System.Controllers;

namespace Movers_Booking_System.Forms;

public partial class ScheduleForm : Form
{
    private Font font = new("Bahnschrift", 15);
    private Brush brush = Brushes.Black;
    private DateTime startOfWeek;
    private int dayIndex;
    public ScheduleForm()
    {
        InitializeComponent();
        startOfWeek = DateTime.Today;
        while (startOfWeek.DayOfWeek != DayOfWeek.Sunday)
        {
            startOfWeek = startOfWeek.AddDays(-1);
        }
        textBox1.Text = startOfWeek.ToShortDateString();
    }

    private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
        PrintController.DrawScheduleHeader(sender, e, startOfWeek, dayIndex);
        e.Graphics.DrawString(JobController.GetDateSummary(startOfWeek.AddDays(dayIndex))
                              + InspectionController.GetDateSummary(startOfWeek.AddDays(dayIndex)), font, brush, new Point(20, 180));

        dayIndex++;
        if (dayIndex <= 6) e.HasMorePages = true;
        else e.HasMorePages = false;
    }

    private void customButtonSubmit_Click(object sender, EventArgs e)
    {
        dayIndex = 0;
        printPreviewDialog.Document = printDocument;
        printDocument.DefaultPageSettings.PaperSize = new("PaperA4", 826, 1169);
        printPreviewDialog.ShowDialog();
    }

    private void buttonBack_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new MainForm());

    private void buttonRight_Click(object sender, EventArgs e)
    {
        startOfWeek = startOfWeek.AddDays(7);
        textBox1.Text = startOfWeek.ToShortDateString();
    }

    private void buttonLeft_Click(object sender, EventArgs e)
    {
        startOfWeek = startOfWeek.AddDays(-7);
        textBox1.Text = startOfWeek.ToShortDateString();
    }
}
