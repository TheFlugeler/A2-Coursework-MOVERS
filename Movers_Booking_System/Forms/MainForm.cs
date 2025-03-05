using Movers_Booking_System.Controllers;
using Movers_Booking_System.Models;
using Movers_Booking_System.Tools;

namespace Movers_Booking_System.Forms;
public partial class MainForm : Form
{
    private bool formsIsCollapsed = true;
    private bool databaseIsCollapsed = true;
    private bool profileIsCollapsed = true;
    private bool printIsCollapsed = true;
    private bool dropdownAnimating = false;
    private int dropdownStep = 15;
    public static string StaffUsername { get; set; }
    public MainForm()
    {
        InitializeComponent();
        panelFormDropdown.Height = panelFormDropdown.MinimumSize.Height;
        panelDatabaseDropdown.Height = panelDatabaseDropdown.MinimumSize.Height;
        panelProfileDropdown.Height = panelProfileDropdown.MinimumSize.Height;
        panelPrintDropdown.Height = panelPrintDropdown.MinimumSize.Height;
        pictureBoxProfile.Image = ProfileController.GetProfileImage(DAL.GetStaffDetails(StaffUsername).Profile);

        bool areMessages = false;
        List<Job> jobs = DAL.GetJobsList();
        foreach (Job j in jobs)
        {
            if (j.Confirmed && j.JobDate < DateTime.Today || !j.Confirmed && j.EstimateDate < DateTime.Today.AddDays(-4))
            {
                areMessages = true;
                break;
            }
        }
        if (areMessages) buttonMessages.BackgroundImage = Image.FromFile("Media/email-alert.png");
        else buttonMessages.BackgroundImage = Image.FromFile("Media/email.png");
    }

    private void panelFormDropdownButton_Click(object sender, EventArgs e) => InitiateDropdown("Form");
    private void panelDatabaseButton_Click(object sender, EventArgs e) => InitiateDropdown("Database");
    private void panelProfileButton_Click(object sender, EventArgs e) => InitiateDropdown("Profile");
    private void panelPrintButton_Click(object sender, EventArgs e) => InitiateDropdown("Print");

    private void InitiateDropdown(string dropdown)
    {
        if (dropdownAnimating) return;
        CollapseOtherDropdowns(dropdown);
        switch (dropdown)
        {
            case "Form":
                timerFormDropdown.Start();
                break;
            case "Database":
                timerDatabaseDropdown.Start();
                break;
            case "Profile":
                timerProfileDropdown.Start();
                break;
            case "Print":
                timerPrintDropdown.Start();
                break;
        }
    }
    private void CollapseOtherDropdowns(string dropdown)
    {
        if (dropdown != "Form" && !formsIsCollapsed) timerFormDropdown.Start();
        else if (dropdown != "Database" && !databaseIsCollapsed) timerDatabaseDropdown.Start();
        else if (dropdown != "Profile" && !profileIsCollapsed) timerProfileDropdown.Start();
        else if (dropdown != "Print" && !printIsCollapsed) timerPrintDropdown.Start();
    }
    private void timerDatabaseDropdown_Tick(object sender, EventArgs e) => DropdownTimerTick(ref databaseIsCollapsed, panelDatabaseDropdown, timerDatabaseDropdown);
    private void timerFormDropdown_Tick(object sender, EventArgs e) => DropdownTimerTick(ref formsIsCollapsed, panelFormDropdown, timerFormDropdown);
    private void timerProfileDropdown_Tick(object sender, EventArgs e) => DropdownTimerTick(ref profileIsCollapsed, panelProfileDropdown, timerProfileDropdown);
    private void timerPrintDropdown_Tick(object sender, EventArgs e) => DropdownTimerTick(ref printIsCollapsed, panelPrintDropdown, timerPrintDropdown);

    private void DropdownTimerTick(ref bool isCollapsed, Panel panel, System.Windows.Forms.Timer timer)
    {
        if (!dropdownAnimating) dropdownAnimating = true;
        if (isCollapsed)
        {
            if (panel.Height >= panel.MaximumSize.Height)
            {
                timer.Stop();
                isCollapsed = false;
                dropdownAnimating = false;
            }
            else panel.Height += dropdownStep;
        }
        else
        {
            if (panel.Height <= panel.MinimumSize.Height)
            {
                timer.Stop();
                isCollapsed = true;
                dropdownAnimating = false;
            }
            else panel.Height -= dropdownStep;
        }
    }

    private void buttonEstimateForm_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new EstimateForm());
    private void buttonCustomerForm_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new CustomerForm());
    private void buttonInspectionForm_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new InspectionForm());
    private void buttonSpecialItemForm_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new SpecialItemForm());
    private void buttonJobForm_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new JobForm());
    private void buttonAccessEstimate_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new DatabaseForm("Job"));
    private void buttonAcessInspection_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new DatabaseForm("Inspection"));
    private void buttonAccessCustomer_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new DatabaseForm("Customer"));
    private void buttonAccessItem_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new DatabaseForm("SpecialItem"));
    private void buttonPrintJob_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new PrintForm(true));
    private void buttonPrintInspection_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new PrintForm(false));
    private void buttonPrintSchedule_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new ScheduleForm());
    private void buttonProfile_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new ProfileForm(false));
    private void buttonMessages_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new MessagesForm());

    private void buttonLogout_Click(object sender, EventArgs e)
    {
        StaffUsername = string.Empty;
        DisplayController.DisplayForm(new LoginForm());
    }
}
