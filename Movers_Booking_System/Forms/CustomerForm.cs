using Movers_Booking_System.Controllers;
using Movers_Booking_System.Models;

namespace Movers_Booking_System.Forms;

public partial class CustomerForm : Form
{
    private bool editMode;
    private string custID;
    public CustomerForm()
    {
        InitializeComponent();
        custID = "";
        editMode = false;
    }
    public CustomerForm(Customer cust)
    {
        InitializeComponent();
        SetEditView();
        custID = cust.ID;
        SetInputs(cust);
    }
    private void customButtonSubmit_Click(object sender, EventArgs e)
    {
        Customer newCust = new Customer("", textBoxForename.Text, textBoxSurname.Text, textBoxTelNo.Text, textBoxEmail.Text);
        if (editMode) newCust.ID = custID;
        if (!CustomerController.WriteCustomer(newCust, editMode))
        {
            MessageBox.Show(CustomerController.ReadErrorMessage(), "Error");
        }
        else
        {
            MessageBox.Show("Customer Updated Successfully", "Update");
            ResetInputs();
            DisplayController.DisplayForm(new MainForm());
        }
    }
    private void SetEditView()
    {
        labelCreateCustomer.Text = "Edit Customer";
        customButtonSubmit.Text = "Update";
    }
    private void SetInputs(Customer cust)
    {
        textBoxForename.Text = cust.Forename;
        textBoxSurname.Text = cust.Surname;
        textBoxTelNo.Text = cust.TelNo;
        textBoxEmail.Text = cust.Email;
        editMode = true;
    }
    private void ResetInputs()
    {
        textBoxForename.Text = string.Empty;
        textBoxSurname.Text = string.Empty;
        textBoxTelNo.Text = string.Empty;
        textBoxEmail.Text = string.Empty;
    }
    private void buttonBack_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new MainForm());
}