using Movers_Booking_System.Controllers;

namespace Movers_Booking_System;
public partial class MasterForm : Form
{
    private Form DisplayedForm = null;
    public MasterForm()
    {
        InitializeComponent();
        DisplayController.SetMasterForm(this);
    }
    public void DisplayForm(Form form)
    {
        if (DisplayedForm != null) DisplayedForm.Close();
        DisplayedForm = form;
        DisplayedForm.Dock = DockStyle.Fill;
        DisplayedForm.FormBorderStyle = FormBorderStyle.None;
        DisplayedForm.TopLevel = false;
        panelMaster.Controls.Add(DisplayedForm);
        DisplayedForm.BringToFront();
        DisplayedForm.Show();
    }
    private void MasterForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();
}
