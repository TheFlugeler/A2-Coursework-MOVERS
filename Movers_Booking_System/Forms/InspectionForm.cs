using Movers_Booking_System.Controllers;
using Movers_Booking_System.Models;

namespace Movers_Booking_System.Forms;

public partial class InspectionForm : Form
{
    private string inspectionID;
    private bool editMode;
    public InspectionForm()
    {
        InitializeComponent();
        dateTimePickerDate.MinDate = DateTime.Today.AddDays(7);
        dateTimePickerDate.MaxDate = DateTime.Today.AddYears(1);
        comboBoxCustomer.DataSource = CustomerController.GetCustomerNames();
        inspectionID = "";
        editMode = false;
    }
    public InspectionForm(Inspection inspection)
    {
        InitializeComponent();
        labelBookInspection.Text = "Update Inspection";
        customButtonSubmit.Text = "Update";

        dateTimePickerDate.MinDate = DateTime.Today;
        dateTimePickerDate.MaxDate = DateTime.Today.AddYears(1);
        comboBoxCustomer.DataSource = CustomerController.GetCustomerNames();
        comboBoxCustomer.SelectedIndex = CustomerController.GetCustomerIndex(inspection.CustomerID);
        textBoxOldAddress.Text = inspection.OldAddress;
        textBoxNewAddress.Text = inspection.NewAddress;
        dateTimePickerDate.Value = inspection.Date;
        checkBoxPaid.Checked = inspection.Paid;

        inspectionID = inspection.ID;
        editMode = true;
    }
    private void customButtonSubmit_Click(object sender, EventArgs e)
    {
        Inspection newInspection = new Inspection(inspectionID,
        CustomerController.GetCustomerID(comboBoxCustomer.SelectedIndex),
        textBoxOldAddress.Text,
        textBoxNewAddress.Text,
        dateTimePickerDate.Value,
        checkBoxPaid.Checked);
        if (InspectionController.WriteInspection(newInspection, editMode))
        {
            MessageBox.Show("Inspection Written Successfully", "Success");
            DisplayController.DisplayForm(new MainForm());
        }
        else MessageBox.Show(InspectionController.ReadErrorMessage(), "Error");
    }
    private void buttonBack_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new MainForm());
}