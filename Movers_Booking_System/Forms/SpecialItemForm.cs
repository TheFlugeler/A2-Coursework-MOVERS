using Movers_Booking_System.Controllers;
using Movers_Booking_System.Models;
using Movers_Booking_System.Tools;

namespace Movers_Booking_System.Forms;

public partial class SpecialItemForm : Form
{
    private bool editMode;
    private string originalName;
    public SpecialItemForm()
    {
        InitializeComponent();
        editMode = false;
    }
    public SpecialItemForm(SpecialItem item)
    {
        InitializeComponent();
        labelCreateSpecialItem.Text = "Update Special Item";
        textBoxName.Text = item.Name;
        originalName = item.Name;
        textBoxPrice.Text = item.Price.ToString();
        numericUpDownWorkers.Value = item.NoWorkers;
        editMode = true;
    }
    private void buttonBack_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new MainForm());
    private void customButtonSubmit_Click(object sender, EventArgs e)
    {
        if (!SpecialItemController.ValidateSpecialItem(textBoxPrice.Text, textBoxName.Text, originalName))
        {
            MessageBox.Show(SpecialItemController.ReadErrorMessage(), "Error");
        }
        else
        {
            double price = Convert.ToDouble(textBoxPrice.Text);
            price = Math.Round(price, 2);
            if (editMode) DAL.UpdateSpecialItem(new SpecialItem(textBoxName.Text, (int)numericUpDownWorkers.Value, price));
            else DAL.WriteNewSpecialItem(new SpecialItem(textBoxName.Text, (int)numericUpDownWorkers.Value, price));
            MessageBox.Show("Special Item has been written to the database", "Update");
            ClearInputs();
            DisplayController.DisplayForm(new MainForm());
        }
    }
    private void ClearInputs()
    {
        textBoxPrice.Text = string.Empty;
        textBoxName.Text = string.Empty;
    }
}
