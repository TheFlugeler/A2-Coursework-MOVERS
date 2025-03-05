using Movers_Booking_System.Models;

namespace Movers_Booking_System.Controllers;

public static class PrintController
{
    private static Brush brush = Brushes.Black;
    private static Font font = new("Bahnschrift", 15);

    public static void DrawInvoiceFooter(object sender, System.Drawing.Printing.PrintPageEventArgs e)
    {
        e.Graphics.DrawString("Bank Transfer Details:\nAccount Name: MOVERS Company\nBank: Bank of Ireland\nSort Code: 00-00-00\nAccount Number: 12345678", font, brush, new Point(20, 900));
        e.Graphics.DrawString("Cheques Payable to: MOVERS Moval Company\nPlease put customer number on reverse", font, brush, new Point(370, 900));
    }

    public static void DrawInvoiceHeader(object sender, System.Drawing.Printing.PrintPageEventArgs e, Job j)
    {
        string heading = $"Customer: {j.CustomerID}\nMoval Date: {j.JobDate.ToShortDateString()}\nAddress: {j.OldAddress}";
        DrawInvoiceHeader(sender, e, heading);
    }
    public static void DrawInvoiceHeader(object sender, System.Drawing.Printing.PrintPageEventArgs e,Inspection i)
    {
        string heading = $"Customer: {i.CustomerID}\nInspection Date: {i.Date.ToShortDateString()}\nAddress: {i.OldAddress}";
        DrawInvoiceHeader(sender, e, heading);        
    }
    private static void DrawInvoiceHeader(object sender, System.Drawing.Printing.PrintPageEventArgs e, string header)
    {
        Image img = Image.FromFile("Media/PrintLogo.png");
        e.Graphics.DrawImage(img, new Point(-30, -100));
        e.Graphics.DrawString("MOVERS - Moval Company", new Font("Bahnschrift", 20), Brushes.Black, new Point(297, 30));
        e.Graphics.DrawString(header, font, Brushes.Black, new Point(300, 65));
        e.Graphics.DrawString($"{DateTime.Today.ToShortDateString()}", font, Brushes.Black, new Point(700, 35));
        e.Graphics.DrawLine(new Pen(brush, 4), new Point(0, 160), new Point(826, 160));
        img.Dispose();
    }
    public static void DrawItemList(object sender, System.Drawing.Printing.PrintPageEventArgs e,string[] lists, string totalCost)
    {
        e.Graphics.DrawString(lists[0], font, brush, new Point(20, 180));
        e.Graphics.DrawString(lists[1], font, brush, new Point(670, 180));
        e.Graphics.DrawString("Total Cost", font, brush, new Point(20, 850));
        e.Graphics.DrawString(totalCost, font, brush, new Point(670, 850));
        e.Graphics.DrawLine(new Pen(brush, 4), new Point(0, 880), new Point(826, 880));
    }
    public static void DrawScheduleHeader(object sender, System.Drawing.Printing.PrintPageEventArgs e, DateTime startOfWeek, int dayIndex)
    {
        Image img = Image.FromFile("Media/PrintLogo.png");
        e.Graphics.DrawImage(img, new Point(-30, -100));
        e.Graphics.DrawString("MOVERS - Moval Company", new Font("Bahnschrift", 20), Brushes.Black, new Point(297, 30));
        e.Graphics.DrawString($"Day: {startOfWeek.AddDays(dayIndex).DayOfWeek} {startOfWeek.AddDays(dayIndex).ToLongDateString()}", font, Brushes.Black, new Point(300, 65));
        e.Graphics.DrawString($"{DateTime.Today.ToShortDateString()}", font, Brushes.Black, new Point(700, 35));
        e.Graphics.DrawLine(new Pen(brush, 4), new Point(0, 160), new Point(826, 160));
        img.Dispose();
    }
}
