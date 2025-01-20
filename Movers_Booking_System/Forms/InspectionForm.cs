using Movers_Booking_System.Controllers;
using Movers_Booking_System.Models;
using Movers_Booking_System.Tools;

namespace Movers_Booking_System.Forms;

public partial class InspectionForm : Form
{
    private string inspectionID;
    private bool editMode;
    public InspectionForm()
    {
        InitializeComponent();
        dateTimePickerDate.MinDate = DateTime.Today;
        dateTimePickerDate.MaxDate = DateTime.Today.AddYears(1);
        comboBoxCustomer.DataSource = CustomerController.GetCustomerNames();
        inspectionID = "";
        editMode = false;
    }
    public InspectionForm(Inspection inspection)
    {
        InitializeComponent();
        SetEditMode();
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
    private void SetEditMode()
    {
        labelBookInspection.Text = "Update Inspection";
        customButtonSubmit.Text = "Update";
    }
    private void buttonBack_Click(object sender, EventArgs e)
    {
        if (editMode)
        {
            DialogResult = MessageBox.Show("You will lose this record if you leave the page\nDo you wish to continue?", "Warning", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.No) return;
        }
        DisplayController.DisplayForm(new MainForm());
    }
    private void customButtonSubmit_Click(object sender, EventArgs e)
    {
        if (InspectionController.ValidateNewInspectionDate(dateTimePickerDate.Value.Date, inspectionID))
        {
            Inspection newInspection = new Inspection("",
                CustomerController.GetCustomerID(comboBoxCustomer.SelectedIndex),
                textBoxOldAddress.Text,
                textBoxNewAddress.Text,
                dateTimePickerDate.Value,
                checkBoxPaid.Checked);
            if (editMode)
            {
                newInspection.ID = inspectionID;
                DAL.UpdateInspection(newInspection);
            }
            else DAL.WriteNewInspection(newInspection);
            MessageBox.Show("Inspection has been successfully booked");
            ClearInputs();
            DisplayController.DisplayForm(new MainForm());
        }
        else
        {
            MessageBox.Show(InspectionController.ReadErrorMessage(), "Error");
            dateTimePickerDate.Value = DateTime.Now;
        }
    }
    private void ClearInputs()
    {
        textBoxOldAddress.Text = string.Empty;
        textBoxNewAddress.Text = string.Empty;
        dateTimePickerDate.Value = DateTime.Now;
        checkBoxPaid.Checked = false;
        comboBoxCustomer.SelectedIndex = 0;
    }

    private void checkBoxPaid_CheckedChanged(object sender, EventArgs e)
    {

    }
}
