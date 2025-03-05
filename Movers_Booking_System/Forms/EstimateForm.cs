using Movers_Booking_System.Controllers;
using Movers_Booking_System.Models;

namespace Movers_Booking_System.Forms;

public partial class EstimateForm : Form
{
    private List<SpecialItem> specialItems = new List<SpecialItem>();
    private bool editMode;
    private bool confirmed;
    private string jobID;
    private int[] originalVans;
    public EstimateForm()
    {
        InitializeComponent();
        comboBoxCustomer.DataSource = CustomerController.GetCustomerNames();
        comboBoxSpecialItem.DataSource = SpecialItemController.GetSpecialItemNames();
        dateTimePickerJobDate.MinDate = DateTime.Now.AddDays(7);
        dateTimePickerJobDate.MaxDate = DateTime.Now.AddYears(1);
        numericUpDownRooms.Minimum = 1;
        numericUpDownRooms.Maximum = 4;
        labelAmountPaid.Visible = false;
        textBoxAmountPaid.Visible = false;
        textBoxAmountPaid.Text = "0";

        originalVans = [0, 0, 0];
        jobID = "";
        confirmed = false;
        editMode = false;
    }
    public EstimateForm(Job job)
    {
        InitializeComponent();

        confirmed = job.Confirmed;
        jobID = job.ID;
        originalVans = [job.NoSmallVans, job.NoMediumVans, job.NoLargeVans];

        if (job.Confirmed) labelCreateEstimate.Text = "Update Job";
        else labelCreateEstimate.Text = "Update Estimate";
        customButtonSubmit.Text = "Update";

        comboBoxCustomer.DataSource = CustomerController.GetCustomerNames();
        comboBoxSpecialItem.DataSource = SpecialItemController.GetSpecialItemNames();
        numericUpDownRooms.Minimum = 1;
        numericUpDownRooms.Maximum = 4;

        comboBoxCustomer.SelectedIndex = CustomerController.GetCustomerIndex(job.CustomerID);
        dateTimePickerJobDate.Value = job.JobDate;
        richTextBoxOldAddress.Text = job.OldAddress;
        richTextBoxNewAddress.Text = job.NewAddress;
        numericUpDownRooms.Value = job.NoRooms;
        numericUpDownBoxes.Value = job.NoBoxes;
        checkBoxSelfPacked.Checked = job.SelfPacked;
        checkBoxFurnitureAssembly.Checked = job.FurnitureAssembly;
        checkBoxApartment.Checked = job.IsApartment;
        richTextBoxExtraRequirements.Text = job.ExtraRequirements;
        specialItems = job.SpecialItems;
        textBoxAmountPaid.Text = job.AmountPaid.ToString();
        labelAmountPaid.Visible = job.Confirmed;
        textBoxAmountPaid.Visible = job.Confirmed;

        editMode = true;
        UpdateItemList();
    }
    private void customButtonAddSpecialItem_Click(object sender, EventArgs e)
    {
        if (comboBoxSpecialItem.SelectedIndex < 0) return;
        specialItems.Add(SpecialItemController.GetSpecialItem(comboBoxSpecialItem.SelectedIndex));
        UpdateItemList();
    }
    private void customButtonRemoveSpecialItem_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < specialItems.Count; i++)
        {
            if (specialItems[i].Name == comboBoxSpecialItem.Text)
            {
                specialItems.RemoveAt(i);
                break;
            }
        }
        UpdateItemList();
    }
    private void UpdateItemList()
    {
        richTextBoxSpecialItems.Clear();
        foreach (SpecialItem s in specialItems) richTextBoxSpecialItems.AppendText($"{s.Name}\n");
    }
    private void checkBoxApartment_CheckedChanged(object sender, EventArgs e)
    {
        if (checkBoxApartment.Checked) numericUpDownRooms.Maximum = 2;
        else numericUpDownRooms.Maximum = 4;
    }
    private void customButtonSubmit_Click(object sender, EventArgs e)
    {
        if (!double.TryParse(textBoxAmountPaid.Text, out double amountPaid))
        {
            MessageBox.Show("Price is in an invalid format");
            return;
        }
        Job job = new Job(jobID, CustomerController.GetCustomerID(comboBoxCustomer.SelectedIndex), DateTime.Today, confirmed,
            dateTimePickerJobDate.Value.Date, richTextBoxOldAddress.Text, richTextBoxNewAddress.Text, (int)numericUpDownRooms.Value, checkBoxApartment.Checked,
            (int)numericUpDownBoxes.Value, checkBoxSelfPacked.Checked, checkBoxFurnitureAssembly.Checked, richTextBoxExtraRequirements.Text, 0, amountPaid,
            0, 0, 0, 0, specialItems);
        if (JobController.WriteJob(job, editMode, originalVans))
        {
            MessageBox.Show("Job Written Successfully", "Success");
            DisplayController.DisplayForm(new MainForm());
        }
        else
        {
            string msg = JobController.ReadErrorMessage();
            if (msg.Contains("200")) return;
            MessageBox.Show(msg, "Error");
            return;
        }
    }
    private void buttonBack_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new MainForm());

    private void numericUpDownBoxes_ValueChanged(object sender, EventArgs e)
    {
        if (numericUpDownBoxes.Value % 10 != 0)
        {
            int value = Convert.ToInt32(Math.Ceiling((double)numericUpDownBoxes.Value / 10));
            numericUpDownBoxes.Value = value * 10;
        }
    }
}
