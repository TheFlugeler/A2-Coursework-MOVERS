using Movers_Booking_System.Forms;
using Movers_Booking_System.Models;
using Movers_Booking_System.Tools;
using System.Data;

namespace Movers_Booking_System.Controllers;

static class DatabaseController
{
    private static string errorMessage = "";
    public static string ReadErrorMessage()
    {
        string msg = errorMessage;
        errorMessage = "";
        return msg;
    }
    public static Customer GetCustomerFromRow(DataGridViewRow row)
    {
        Customer cust = new Customer(
            (string)row.Cells[0].Value,
            (string)row.Cells[1].Value,
            (string)row.Cells[2].Value,
            (string)row.Cells[3].Value,
            (string)row.Cells[4].Value);
        return cust;
    }
    public static Inspection GetInspectionFromRow(DataGridViewRow row)
    {
        Inspection inspection = new Inspection(
            (string)row.Cells[0].Value,
            (string)row.Cells[1].Value,
            (string)row.Cells[2].Value,
            (string)row.Cells[3].Value,
            (DateTime)row.Cells[4].Value,
            (bool)row.Cells[5].Value);
        return inspection;
    }
    public static Job GetJobFromRow(DataGridViewRow row)
    {
        List<SpecialItem> items = DAL.GetSpecialItems((string)row.Cells[0].Value);
        Job job = new Job(
            (string)row.Cells[0].Value,
            (string)row.Cells[1].Value,
            (DateTime)row.Cells[2].Value,
            (bool)row.Cells[3].Value,
            (DateTime)row.Cells[4].Value,
            (string)row.Cells[5].Value,
            (string)row.Cells[6].Value,
            (int)row.Cells[7].Value,
            (bool)row.Cells[8].Value,
            (int)row.Cells[9].Value,
            (bool)row.Cells[10].Value,
            (bool)row.Cells[11].Value,
            (string)row.Cells[12].Value,
            Convert.ToDouble(row.Cells[13].Value),
            Convert.ToDouble(row.Cells[14].Value),
            (int)row.Cells[15].Value,
            (int)row.Cells[16].Value,
            (int)row.Cells[17].Value,
            (int)row.Cells[18].Value,
            items);
        return job;
    }
    public static SpecialItem GetItemFromRow(DataGridViewRow row)
    {
        SpecialItem item = new SpecialItem(
            (string)row.Cells[0].Value,
            (int)row.Cells[1].Value,
            Convert.ToDouble(row.Cells[2].Value));
        return item;
    }
    public static bool ValidateDelete(DataGridViewSelectedRowCollection rows, string database)
    {
        if (rows.Count != 1)
        {
            errorMessage = "Invalid number of rows selected";
            return false;
        }

        string id = (string)rows[0].Cells[0].Value;
        if (database == "Job")
        {
            int noItems = DAL.GetNoSpecialItems(id);
            errorMessage = $"Deleting this record will result in {noItems} connecting records being deleted\nDo you wish to continue?";
        }
        else if (database == "SpecialItem")
        {
            int noJobs = DAL.GetNoJobs(id);
            errorMessage = $"Deleting this record will result in {noJobs} connecting records being deleted\nDo you wish to continue?";
        }
        else if (database == "Customer")
        {
            int noRecords = DAL.GetNoCustomerRecords(id);
            errorMessage = $"Deleting this record will result in {noRecords} Job/ Inspection records being deleted\nDo you wish to continue?";
        }
        return true;
    }
    public static void DeleteRecord(DataGridViewRow row, string database)
    {
        string id = (string)row.Cells[0].Value;
        DAL.DeleteRecord(id, database);
    }
    public static bool EditRecord(DataGridViewSelectedRowCollection rows, string database)
    {
        if (rows.Count != 1)
        {
            errorMessage = "Invalid number of rows selected";
            return false;
        }
        switch (database)
        {
            case "Customer":
                Customer cust = GetCustomerFromRow(rows[0]);
                DisplayController.DisplayForm(new CustomerForm(cust));
                break;
            case "Inspection":
                Inspection insp = GetInspectionFromRow(rows[0]);
                DisplayController.DisplayForm(new InspectionForm(insp));
                break;
            case "Job":
                Job job = GetJobFromRow(rows[0]);
                DisplayController.DisplayForm(new EstimateForm(job));
                break;
            case "SpecialItem":
                SpecialItem item = GetItemFromRow(rows[0]);
                DisplayController.DisplayForm(new SpecialItemForm(item));
                break;
            default: break;
        }
        return true;
    }

    public static DataTable GetDatabaseRows(string database)
    {
        return DAL.GetFullDatabase(database);
    }
}
