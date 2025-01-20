using Movers_Booking_System.Controllers;
using Movers_Booking_System.Models;
using Movers_Booking_System.Tools;

namespace Movers_Booking_System.Forms;

public partial class EstimateForm : Form
{
    private List<SpecialItem> specialItems = new List<SpecialItem>();
    private bool editMode;
    private Job selectedJob;
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

        editMode = false;
    }
    public EstimateForm(Job job)
    {
        InitializeComponent();
        selectedJob = job;

        if (job.Confirmed) labelCreateEstimate.Text = "Update Estimate";
        else customButtonSubmit.Text = "Update";
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
        bool isHoliday = false;
        int[] vans = EstimateController.CalculateTotalVans((int)numericUpDownRooms.Value, specialItems);
        int[] originalVans = [0,0,0]; 
        if(editMode) originalVans = [selectedJob.NoSmallVans,selectedJob.NoMediumVans,selectedJob.NoLargeVans];
        int noWorkers = EstimateController.CalculateTotalWorkers((int)numericUpDownRooms.Value, specialItems);
        if (!EstimateController.VerifyEstimateDate(dateTimePickerJobDate.Value.Date, noWorkers, vans, originalVans))
        {
            string msg = EstimateController.ReadErrorMessage();
            if (msg.Contains("200"))
            {
                DialogResult dr = MessageBox.Show(msg, "Error", MessageBoxButtons.YesNo);
                if (dr == DialogResult.No) return;
                else isHoliday = true;
            }
            else
            {
                MessageBox.Show(msg, "Error");
                return;
            }
        }

        double price = EstimateController.CalculateEstimateCost((int)numericUpDownRooms.Value, checkBoxApartment.Checked, (int)numericUpDownBoxes.Value, checkBoxSelfPacked.Checked, checkBoxFurnitureAssembly.Checked, specialItems, isHoliday);
        string custID = CustomerController.GetCustomerID(comboBoxCustomer.SelectedIndex);

        Job newJob = new Job("", custID, DateTime.Today, false, dateTimePickerJobDate.Value.Date, richTextBoxOldAddress.Text,
            richTextBoxNewAddress.Text, (int)numericUpDownRooms.Value, checkBoxApartment.Checked, (int)numericUpDownBoxes.Value, checkBoxSelfPacked.Checked,
            checkBoxFurnitureAssembly.Checked, richTextBoxExtraRequirements.Text, price, 0, noWorkers, vans[0], vans[1], vans[2], specialItems);

        if (editMode)
        {
            newJob.Confirmed = selectedJob.Confirmed;
            newJob.ID = selectedJob.ID;
            if (!double.TryParse(textBoxAmountPaid.Text, out double _))
            {
                MessageBox.Show("Amount paid is in an invalid format", "Error");
                return;
            }
            newJob.AmountPaid = Convert.ToDouble(textBoxAmountPaid.Text);
            DAL.UpdateJob(newJob);
        }
        else DAL.WriteNewJob(newJob);

        MessageBox.Show("Job updated successfully", "Success");
        DisplayController.DisplayForm(new MainForm());
    }
    private void buttonBack_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new MainForm());
}
