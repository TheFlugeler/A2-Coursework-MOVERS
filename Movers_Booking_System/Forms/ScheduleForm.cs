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
    }

    private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
        DrawHeader(sender, e);
        e.Graphics.DrawString(JobController.GetDateSummary(startOfWeek.AddDays(dayIndex))
                              + InspectionController.GetDateSummary(startOfWeek.AddDays(dayIndex)), font, brush, new Point(20, 180));
        
        dayIndex++;
        if (dayIndex <= 6) e.HasMorePages = true;
        else e.HasMorePages = false;
    }

    private void DrawHeader(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
        Image img = Image.FromFile("Media/PrintLogo.png");
        e.Graphics.DrawImage(img, new Point(-30, -100));
        e.Graphics.DrawString("MOVERS - Moval Company", new Font("Bahnschrift", 20), Brushes.Black, new Point(297, 30));
        e.Graphics.DrawString($"Day: {startOfWeek.AddDays(dayIndex).DayOfWeek} {startOfWeek.AddDays(dayIndex).ToLongDateString()}", font, Brushes.Black, new Point(300, 65));
        e.Graphics.DrawString($"{DateTime.Today.ToShortDateString()}", font, Brushes.Black, new Point(700, 35));
        e.Graphics.DrawLine(new Pen(brush, 4), new Point(0, 160), new Point(826, 160));
        img.Dispose();
    }

    private void customButtonSubmit_Click(object sender, EventArgs e)
    {
        if (dateTimePicker.Value.DayOfWeek != DayOfWeek.Sunday)
        {
            MessageBox.Show("Day selected is not a Sunday", "Error");
            return;
        }
        startOfWeek = dateTimePicker.Value;
        dayIndex = 0;
        printPreviewDialog.Document = printDocument;
        printDocument.DefaultPageSettings.PaperSize = new("PaperA4", 826, 1169);
        printPreviewDialog.ShowDialog();
    }

    private void buttonBack_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new MainForm());
}
