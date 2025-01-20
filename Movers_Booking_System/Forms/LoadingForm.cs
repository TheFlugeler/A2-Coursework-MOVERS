using Movers_Booking_System.Controllers;

namespace Movers_Booking_System.Forms;

public partial class LoadingForm : Form
{
    private int maxLength = 371;
    private int startLength = 30;
    public LoadingForm()
    {
        InitializeComponent();
        customPanelBar.Width = startLength;
        timerBar.Start();
    }

    private void LaunchMainForm()
    {
        Hide();
        MasterForm masterForm = new MasterForm();
        masterForm.Show();
        DisplayController.DisplayForm(new LoginForm());
    }

    private void timerBar_Tick(object sender, EventArgs e)
    {
        if (customPanelBar.Width < maxLength)
        {
            customPanelBar.Width++;
            customPanelBar.Invalidate();
        }
        else
        {
            timerBar.Stop();
            LaunchMainForm();
        }
    }
}
