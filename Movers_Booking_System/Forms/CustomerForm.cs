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
        custID = cust.ID;
        editMode = true;
        labelCreateCustomer.Text = "Edit Customer";
        customButtonSubmit.Text = "Update";
        SetInputs(cust);
    }
    private void customButtonSubmit_Click(object sender, EventArgs e)
    {
        Customer newCust = new Customer(custID, textBoxForename.Text, textBoxSurname.Text, textBoxTelNo.Text, textBoxEmail.Text);
        if (!CustomerController.WriteCustomer(newCust, editMode)) MessageBox.Show(CustomerController.ReadErrorMessage(), "Error");
        else
        {
            MessageBox.Show("Customer Updated Successfully", "Update");
            DisplayController.DisplayForm(new MainForm());
        }
    }
    private void SetInputs(Customer cust)
    {
        textBoxForename.Text = cust.Forename;
        textBoxSurname.Text = cust.Surname;
        textBoxTelNo.Text = cust.TelNo;
        textBoxEmail.Text = cust.Email;
    }
    private void buttonBack_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new MainForm());
}