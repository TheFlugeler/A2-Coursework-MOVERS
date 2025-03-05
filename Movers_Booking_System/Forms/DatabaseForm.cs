using Movers_Booking_System.Controllers;

namespace Movers_Booking_System.Forms;
public partial class DatabaseForm : Form
{
    private string database;
    public DatabaseForm(string database)
    {
        InitializeComponent();
        this.database = database;
        UpdateDatabase();
    }
    private void UpdateDatabase() => dataGridViewDatabase.DataSource = DatabaseController.GetDatabaseRows(database);
    private void customButtonDelete_Click(object sender, EventArgs e)
    {
        DialogResult dr = MessageBox.Show("Are you sure you want to delete this record?", "Delete", MessageBoxButtons.YesNo);
        if (dr == DialogResult.No) return;

        if (!DatabaseController.ValidateDelete(dataGridViewDatabase.SelectedRows, database))
        {
            MessageBox.Show(DatabaseController.ReadErrorMessage(), "Error");
            return;
        }
        string msg = DatabaseController.ReadErrorMessage();
        if (msg.Contains("continue"))
        {
            dr = MessageBox.Show(msg, "Delete", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) return;
        }

        DatabaseController.DeleteRecord(dataGridViewDatabase.SelectedRows[0], database);
        UpdateDatabase();
    }
    private void customButtonEdit_Click(object sender, EventArgs e)
    {
        if (!DatabaseController.EditRecord(dataGridViewDatabase.SelectedRows, database))
        {
            MessageBox.Show(DatabaseController.ReadErrorMessage(), "Error");
            return;
        }
        UpdateDatabase();
    }
    private void buttonBack_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new MainForm());
}
//FIX DELETING STAFF PROFILES ADD CHECK
//PUT INTO TESTING SO THERES ACC GOOD STUFF THERE
//UPDATE STORYBOARDS TOO

