using Microsoft.Data.SqlClient;
using Movers_Booking_System.Controllers;
using Movers_Booking_System.Models;
using System.Configuration;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Movers_Booking_System.Tools;

public static class DAL
{
    static readonly string _connectionString = ConfigurationManager.ConnectionStrings["MoversDatabase"].ConnectionString;

    #region Read
    public static DataTable GetFullDatabase(string tableName)
    {
        DataTable dt = new DataTable();
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            connection.Open();

            string query = $"SELECT * FROM {tableName}";
            SqlCommand cmd = new(query, connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            connection.Close();
            da.Dispose();
        }
        return dt;
    }
    public static List<Customer> GetCustomerList()
    {
        List<Customer> customerList = new();
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();

            string query = $"SELECT * FROM Customer";
            SqlCommand cmd = new(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                customerList.Add(new(
                    (string)reader["ID"],
                    (string)reader["Forename"],
                    (string)reader["Surname"],
                    (string)reader["TelNo"],
                    (string)reader["Email"]));
            }

            connection.Close();
            reader.Dispose();
            cmd.Dispose();
        }
        return customerList;
    }

    public static List<SpecialItem> GetSpecialItemsList()
    {
        List<SpecialItem> specialItemList = new();
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();

            string query = $"SELECT * FROM SpecialItem";
            SqlCommand cmd = new(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                specialItemList.Add(new(
                    (string)reader["Name"],
                    (int)reader["NoWorkers"],
                    Convert.ToDouble(reader["Price"])));
            }

            connection.Close();
            reader.Dispose();
            cmd.Dispose();
        }
        return specialItemList;
    }

    public static List<Job> GetJobsList()
    {
        List<Job> jobList = new();
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();

            string query = $"SELECT * FROM Job";
            SqlCommand cmd = new(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                jobList.Add(new(
                    (string)reader["ID"],
                    (string)reader["CustomerID"],
                    (DateTime)reader["EstimateDate"],
                    (bool)reader["Confirmed"],
                    (DateTime)reader["JobDate"],
                    (string)reader["OldAddress"],
                    (string)reader["NewAddress"],
                    (int)reader["NoRooms"],
                    (bool)reader["IsApartment"],
                    (int)reader["NoBoxes"],
                    (bool)reader["SelfPacked"],
                    (bool)reader["FurnitureAssembly"],
                    (string)reader["ExtraRequirements"],
                    Convert.ToDouble(reader["Price"]),
                    Convert.ToDouble(reader["AmountPaid"]),
                    (int)reader["NoWorkers"],
                    (int)reader["NoSmallVans"],
                    (int)reader["NoMediumVans"],
                    (int)reader["NoLargeVans"],
                    new List<SpecialItem>()));
            }
            connection.Close();
            reader.Dispose();
            cmd.Dispose();
        }
        foreach (Job j in jobList) j.SpecialItems = GetSpecialItems(j.ID);

        return jobList;
    }
    public static List<Inspection> GetInspectionsList()
    {
        List<Inspection> inspectionsList = new();
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();

            string query = $"SELECT * FROM Inspection";
            SqlCommand cmd = new(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                inspectionsList.Add(new(
                    (string)reader["ID"],
                    (string)reader["CustomerID"],
                    (string)reader["OldAddress"],
                    (string)reader["NewAddress"],
                    Convert.ToDateTime(reader["Date"]),
                    (bool)reader["Paid"]));
            }
            connection.Close();
            reader.Dispose();
            cmd.Dispose();
        }

        return inspectionsList;
    }
    public static Staff? GetStaffDetails(string username)
    {
        Staff? staff;
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();

            string query = $"SELECT * FROM Staff WHERE Username='{username}'";
            SqlCommand cmd = new(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                staff = new((string)reader["Username"], (string)reader["Password"], (string)reader["Salt"], 
                    (string)reader["Forename"], (string)reader["Surname"], (int)reader["Profile"]);
            }
            else staff = null;
            connection.Close();
            reader.DisposeAsync();
            cmd.Dispose();
        }
        return staff;
    }

    public static List<string> GetIDFromTable(string tableName)
    {
        List<string> idList = new();
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();

            string query = $"SELECT ID FROM {tableName}";
            SqlCommand cmd = new(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                idList.Add((string)reader["ID"]);
            }

            connection.Close();
            reader.Dispose();
            cmd.Dispose();
        }
        return idList;
    }

    public static int GetMatchingInspectionDates(DateTime date)
    {
        int noDates = 0;
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();

            string query = $"SELECT * FROM Inspection WHERE Date='{date:yyyy-MM-dd}'";
            SqlCommand cmd = new(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) noDates++;

            connection.Close();
            reader.DisposeAsync();
            cmd.Dispose();
        }
        return noDates;
    }

    public static DateTime GetInspectionDate(string id)
    {
        DateTime date = DateTime.Now;
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();

            string query = $"SELECT * FROM Inspection WHERE ID='{id}'";
            SqlCommand cmd = new(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            reader.Read();
            date = (DateTime)reader["Date"];

            connection.Close();
            reader.DisposeAsync();
            cmd.Dispose();
        }
        return date;
    }

    public static int GetWorkersOnDate(DateTime date)
    {
        int noWorkers = 0;
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();

            string query = $"SELECT NoWorkers FROM Job WHERE JobDate='{date:yyyy-MM-dd}'";
            SqlCommand cmd = new(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) noWorkers += (int)reader["NoWorkers"];

            connection.Close();
            reader.DisposeAsync();
            cmd.Dispose();
        }
        return noWorkers;
    }

    public static int[] GetVansOnDate(DateTime date)
    {
        int[] vans = new int[3];
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();

            string query = $"SELECT NoSmallVans, NoMediumVans, NoLargeVans FROM Job WHERE JobDate='{date:yyyy-MM-dd}'";
            SqlCommand cmd = new(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                vans[0] += (int)reader["NoSmallVans"];
                vans[1] += (int)reader["NoMediumVans"];
                vans[2] += (int)reader["NoLargeVans"];
            }

            connection.Close();
            reader.DisposeAsync();
            cmd.Dispose();
        }
        return vans;
    }

    public static List<SpecialItem> GetSpecialItems(string jobID)
    {
        List<string> itemNames = new();
        List<SpecialItem> items = new();
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();

            string query = $"SELECT * FROM JobSpecialItem WHERE JobID = '{jobID}'";
            SqlCommand cmd = new(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string name = (string)reader["SpecialItemName"];
                for (int i = 0; i < (int)reader["Quantity"]; i++) itemNames.Add(name);                
            }

            connection.Close();
            reader.DisposeAsync();
            cmd.Dispose();
        }

        foreach (string name in itemNames)
        {
            using (SqlConnection connection = new(_connectionString))
            {
                connection.Open();

                string query = $"SELECT * FROM SpecialItem WHERE Name = '{name}'";
                SqlCommand cmd = new(query, connection);
                SqlDataReader reader = cmd.ExecuteReader();

                reader.Read();
                items.Add(new SpecialItem((string)reader["Name"], (int)reader["NoWorkers"], Convert.ToDouble(reader["Price"])));

                connection.Close();
                reader.DisposeAsync();
                cmd.Dispose();
            }
        }
        return items;
    }

    public static int GetNoSpecialItems(string jobID)
    {
        int noItems = 0;
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();

            string query = $"SELECT * FROM JobSpecialItem WHERE JobID = '{jobID}'";
            SqlCommand cmd = new(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) noItems++;

            connection.Close();
            reader.DisposeAsync();
            cmd.Dispose();
        }
        return noItems;
    }

    public static int GetNoJobs(string specialItemID)
    {
        int noItems = 0;
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();

            string query = $"SELECT * FROM JobSpecialItem WHERE SpecialItemName = '{specialItemID}'";
            SqlCommand cmd = new(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) noItems++;

            connection.Close();
            reader.DisposeAsync();
            cmd.Dispose();
        }
        return noItems;
    }

    public static List<Job> GetJobsOnDate(DateTime date)
    {
        List<Job> jobList = new();
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();

            string query = $"SELECT * FROM Job WHERE JobDate = '{date.ToString("yyyy-MM-dd")}'";
            SqlCommand cmd = new(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                jobList.Add(new(
                    (string)reader["ID"],
                    (string)reader["CustomerID"],
                    (DateTime)reader["EstimateDate"],
                    (bool)reader["Confirmed"],
                    (DateTime)reader["JobDate"],
                    (string)reader["OldAddress"],
                    (string)reader["NewAddress"],
                    (int)reader["NoRooms"],
                    (bool)reader["IsApartment"],
                    (int)reader["NoBoxes"],
                    (bool)reader["SelfPacked"],
                    (bool)reader["FurnitureAssembly"],
                    (string)reader["ExtraRequirements"],
                    Convert.ToDouble(reader["Price"]),
                    Convert.ToDouble(reader["AmountPaid"]),
                    (int)reader["NoWorkers"],
                    (int)reader["NoSmallVans"],
                    (int)reader["NoMediumVans"],
                    (int)reader["NoLargeVans"],
                    new List<SpecialItem>()));
            }
            connection.Close();
            reader.Dispose();
            cmd.Dispose();
        }
        foreach (Job j in jobList) j.SpecialItems = GetSpecialItems(j.ID);

        return jobList;
    }

    public static List<Inspection> GetInspectionsOnDate(DateTime date)
    {
        List<Inspection> inspectionsList = new();
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();

            string query = $"SELECT * FROM Inspection WHERE Date = '{date.ToString("yyyy-MM-dd")}'";
            SqlCommand cmd = new(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                inspectionsList.Add(new(
                    (string)reader["ID"],
                    (string)reader["CustomerID"],
                    (string)reader["OldAddress"],
                    (string)reader["NewAddress"],
                    Convert.ToDateTime(reader["Date"]),
                    (bool)reader["Paid"]));
            }
            connection.Close();
            reader.Dispose();
            cmd.Dispose();
        }

        return inspectionsList;
    }

    public static List<string> GetStaffUsernames()
    {
        List<string> usernameList = new();
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();

            string query = $"SELECT Username FROM Staff";
            SqlCommand cmd = new(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                usernameList.Add((string)reader["Username"]);
            }
            connection.Close();
            reader.Dispose();
            cmd.Dispose();
        }

        return usernameList;
    }

    public static int GetNoCustomerRecords(string custID)
    {
        int noRecords = 0;
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();

            string query = $"SELECT * FROM Job WHERE CustomerID = '{custID}'";
            SqlCommand cmd = new(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) noRecords++;

            connection.Close();
            reader.DisposeAsync();
            cmd.Dispose();
        }
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();

            string query = $"SELECT * FROM Inspection WHERE CustomerID = '{custID}'";
            SqlCommand cmd = new(query, connection);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) noRecords++;

            connection.Close();
            reader.DisposeAsync();
            cmd.Dispose();
        }
        return noRecords;
    }
    #endregion

    #region WriteNew
    public static int WriteNewCustomer(Customer cust)
    {
        int rowsAffected;
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();
            SqlCommand InsertCustomerCommand = new();

            InsertCustomerCommand.Connection = connection;
            InsertCustomerCommand.CommandType = CommandType.StoredProcedure;
            InsertCustomerCommand.CommandText = "AddCustomer";

            cust.ID = CustomerController.GenerateNewCustID();

            InsertCustomerCommand.Parameters.Add(new SqlParameter("@id", cust.ID));
            InsertCustomerCommand.Parameters.Add(new SqlParameter("@forename", cust.Forename));
            InsertCustomerCommand.Parameters.Add(new SqlParameter("@surname", cust.Surname));
            InsertCustomerCommand.Parameters.Add(new SqlParameter("@telno", cust.TelNo));
            InsertCustomerCommand.Parameters.Add(new SqlParameter("@email", cust.Email));

            rowsAffected = InsertCustomerCommand.ExecuteNonQuery();

            connection.Close();
        }
        return rowsAffected;
    }

    public static int WriteNewInspection(Inspection inspection)
    {
        int rowsAffected;
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();
            SqlCommand InsertInspectionCommand = new();

            InsertInspectionCommand.Connection = connection;
            InsertInspectionCommand.CommandType = CommandType.StoredProcedure;
            InsertInspectionCommand.CommandText = "AddInspection";

            inspection.ID = InspectionController.GenerateNewInspectionID();

            InsertInspectionCommand.Parameters.Add(new SqlParameter("@id", inspection.ID));
            InsertInspectionCommand.Parameters.Add(new SqlParameter("@customerID", inspection.CustomerID));
            InsertInspectionCommand.Parameters.Add(new SqlParameter("@oldAddress", inspection.OldAddress));
            InsertInspectionCommand.Parameters.Add(new SqlParameter("@newAddress", inspection.NewAddress));
            InsertInspectionCommand.Parameters.Add(new SqlParameter("@date", inspection.Date.ToString("yyyy-MM-dd")));
            InsertInspectionCommand.Parameters.Add(new SqlParameter("@paid", inspection.Paid));

            rowsAffected = InsertInspectionCommand.ExecuteNonQuery();

            connection.Close();
        }
        return rowsAffected;
    }

    public static int WriteNewSpecialItem(SpecialItem item)
    {
        int rowsAffected;
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();
            SqlCommand InsertSpecialItemCommand = new();

            InsertSpecialItemCommand.Connection = connection;
            InsertSpecialItemCommand.CommandType = CommandType.StoredProcedure;
            InsertSpecialItemCommand.CommandText = "AddSpecialItem";

            InsertSpecialItemCommand.Parameters.Add(new SqlParameter("@name", item.Name));
            InsertSpecialItemCommand.Parameters.Add(new SqlParameter("@noWorkers", item.NoWorkers));
            InsertSpecialItemCommand.Parameters.Add(new SqlParameter("@price", Convert.ToDecimal(item.Price)));
            rowsAffected = InsertSpecialItemCommand.ExecuteNonQuery();

            connection.Close();
        }
        return rowsAffected;
    }

    public static int WriteNewJob(Job job)
    {
        int rowsAffected;
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();
            SqlCommand InsertJobCommand = new();

            InsertJobCommand.Connection = connection;
            InsertJobCommand.CommandType = CommandType.StoredProcedure;
            InsertJobCommand.CommandText = "AddJob";

            job.ID = EstimateController.GenerateNewJobID();

            InsertJobCommand.Parameters.Add(new SqlParameter("@id", job.ID));
            InsertJobCommand.Parameters.Add(new SqlParameter("@customerID", job.CustomerID));
            InsertJobCommand.Parameters.Add(new SqlParameter("@estimateDate", job.EstimateDate.ToString("yyyy-MM-dd")));
            InsertJobCommand.Parameters.Add(new SqlParameter("@confirmed", false));
            InsertJobCommand.Parameters.Add(new SqlParameter("@jobDate", job.JobDate));
            InsertJobCommand.Parameters.Add(new SqlParameter("@oldAddress", job.OldAddress));
            InsertJobCommand.Parameters.Add(new SqlParameter("@newAddress", job.NewAddress));
            InsertJobCommand.Parameters.Add(new SqlParameter("@noRooms", job.NoRooms));
            InsertJobCommand.Parameters.Add(new SqlParameter("@isApartment", job.IsApartment));
            InsertJobCommand.Parameters.Add(new SqlParameter("@noBoxes", job.NoBoxes));
            InsertJobCommand.Parameters.Add(new SqlParameter("@selfPacked", job.SelfPacked));
            InsertJobCommand.Parameters.Add(new SqlParameter("@furnitureAssembly", job.FurnitureAssembly));
            InsertJobCommand.Parameters.Add(new SqlParameter("@extraRequirements", job.ExtraRequirements));
            InsertJobCommand.Parameters.Add(new SqlParameter("@price", job.Price));
            InsertJobCommand.Parameters.Add(new SqlParameter("@amountPaid", job.AmountPaid));
            InsertJobCommand.Parameters.Add(new SqlParameter("@noWorkers", job.NoWorkers));
            InsertJobCommand.Parameters.Add(new SqlParameter("@noSmallVans", job.NoSmallVans));
            InsertJobCommand.Parameters.Add(new SqlParameter("@noMediumVans", job.NoMediumVans));
            InsertJobCommand.Parameters.Add(new SqlParameter("@noLargeVans", job.NoLargeVans));
            rowsAffected = InsertJobCommand.ExecuteNonQuery();

            connection.Close();
        }

        WriteJobSpecialItems(job.ID, job.SpecialItems);
        return rowsAffected;
    }

    private static void WriteJobSpecialItems(string id, List<SpecialItem> items)
    {
        string[] itemNames = new string[items.Count];
        List<string> uniqueItemNames = new List<string>();
        List<int> itemQuantities = new List<int>();

        for (int i = 0; i < items.Count; i++) itemNames[i] = items[i].Name;

        for (int i = 0; i < itemNames.Length; i++)
        {
            if (!uniqueItemNames.Contains(itemNames[i]))
            {
                int quantity = 0;
                foreach (string s in itemNames) if (s == itemNames[i]) quantity++;
                uniqueItemNames.Add(itemNames[i]);
                itemQuantities.Add(quantity);
            }
        }

        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();

            for (int i = 0; i < uniqueItemNames.Count; i++)
            {
                SqlCommand InsertJobItemCommand = new();
                InsertJobItemCommand.Connection = connection;
                InsertJobItemCommand.CommandType = CommandType.StoredProcedure;
                InsertJobItemCommand.CommandText = "AddJobItem";

                InsertJobItemCommand.Parameters.Add(new SqlParameter("@jobID", id));
                InsertJobItemCommand.Parameters.Add(new SqlParameter("@specialItemName", uniqueItemNames[i]));
                InsertJobItemCommand.Parameters.Add(new SqlParameter("@quantity", itemQuantities[i]));
                InsertJobItemCommand.ExecuteNonQuery();
                InsertJobItemCommand.Dispose();
            }

            connection.Close();
        }
    }

    public static void WriteNewStaff(Staff staff)
    {
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();
            SqlCommand InsertSpecialItemCommand = new();

            InsertSpecialItemCommand.Connection = connection;
            InsertSpecialItemCommand.CommandType = CommandType.StoredProcedure;
            InsertSpecialItemCommand.CommandText = "AddStaff";

            InsertSpecialItemCommand.Parameters.Add(new SqlParameter("@username", staff.Username));
            InsertSpecialItemCommand.Parameters.Add(new SqlParameter("@password", staff.Password));
            InsertSpecialItemCommand.Parameters.Add(new SqlParameter("@salt", staff.Salt));
            InsertSpecialItemCommand.Parameters.Add(new SqlParameter("@forename", staff.Forename));
            InsertSpecialItemCommand.Parameters.Add(new SqlParameter("@surname", staff.Surname));
            InsertSpecialItemCommand.Parameters.Add(new SqlParameter("@profile", staff.Profile));
            InsertSpecialItemCommand.ExecuteNonQuery();

            connection.Close();
        }
    }
    #endregion

    #region Update
    public static int UpdateCustomer(Customer cust)
    {
        int rowsAffected;
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();
            SqlCommand UpdateCustomerCommand = new();

            UpdateCustomerCommand.Connection = connection;
            UpdateCustomerCommand.CommandType = CommandType.StoredProcedure;
            UpdateCustomerCommand.CommandText = "UpdateCustomer";


            UpdateCustomerCommand.Parameters.Add(new SqlParameter("@id", cust.ID));
            UpdateCustomerCommand.Parameters.Add(new SqlParameter("@forename", cust.Forename));
            UpdateCustomerCommand.Parameters.Add(new SqlParameter("@surname", cust.Surname));
            UpdateCustomerCommand.Parameters.Add(new SqlParameter("@telno", cust.TelNo));
            UpdateCustomerCommand.Parameters.Add(new SqlParameter("@email", cust.Email));

            rowsAffected = UpdateCustomerCommand.ExecuteNonQuery();

            connection.Close();
        }
        return rowsAffected;
    }

    public static int UpdateInspection(Inspection inspection)
    {
        int rowsAffected;
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();
            SqlCommand UpdateInspectionCommand = new();

            UpdateInspectionCommand.Connection = connection;
            UpdateInspectionCommand.CommandType = CommandType.StoredProcedure;
            UpdateInspectionCommand.CommandText = "UpdateInspection";

            UpdateInspectionCommand.Parameters.Add(new SqlParameter("@id", inspection.ID));
            UpdateInspectionCommand.Parameters.Add(new SqlParameter("@customerID", inspection.CustomerID));
            UpdateInspectionCommand.Parameters.Add(new SqlParameter("@oldAddress", inspection.OldAddress));
            UpdateInspectionCommand.Parameters.Add(new SqlParameter("@newAddress", inspection.NewAddress));
            UpdateInspectionCommand.Parameters.Add(new SqlParameter("@date", inspection.Date.ToString("yyyy-MM-dd")));
            UpdateInspectionCommand.Parameters.Add(new SqlParameter("@paid", inspection.Paid));

            rowsAffected = UpdateInspectionCommand.ExecuteNonQuery();

            connection.Close();
        }
        return rowsAffected;
    }

    public static int UpdateSpecialItem(SpecialItem item)
    {
        int rowsAffected;
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();
            SqlCommand UpdateSpecialItemCommand = new();

            UpdateSpecialItemCommand.Connection = connection;
            UpdateSpecialItemCommand.CommandType = CommandType.StoredProcedure;
            UpdateSpecialItemCommand.CommandText = "UpdateSpecialItem";

            UpdateSpecialItemCommand.Parameters.Add(new SqlParameter("@name", item.Name));
            UpdateSpecialItemCommand.Parameters.Add(new SqlParameter("@noWorkers", item.NoWorkers));
            UpdateSpecialItemCommand.Parameters.Add(new SqlParameter("@price", Convert.ToDecimal(item.Price)));

            rowsAffected = UpdateSpecialItemCommand.ExecuteNonQuery();

            connection.Close();
        }
        return rowsAffected;
    }

    public static int UpdateJob(Job job)
    {
        int rowsAffected;
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();
            SqlCommand UpdateJobCommand = new();

            UpdateJobCommand.Connection = connection;
            UpdateJobCommand.CommandType = CommandType.StoredProcedure;
            UpdateJobCommand.CommandText = "UpdateJob";

            UpdateJobCommand.Parameters.Add(new SqlParameter("@id", job.ID));
            UpdateJobCommand.Parameters.Add(new SqlParameter("@customerID", job.CustomerID));
            UpdateJobCommand.Parameters.Add(new SqlParameter("@estimateDate", job.EstimateDate.ToString("yyyy-MM-dd")));
            UpdateJobCommand.Parameters.Add(new SqlParameter("@confirmed", job.Confirmed));
            UpdateJobCommand.Parameters.Add(new SqlParameter("@jobDate", job.JobDate));
            UpdateJobCommand.Parameters.Add(new SqlParameter("@oldAddress", job.OldAddress));
            UpdateJobCommand.Parameters.Add(new SqlParameter("@newAddress", job.NewAddress));
            UpdateJobCommand.Parameters.Add(new SqlParameter("@noRooms", job.NoRooms));
            UpdateJobCommand.Parameters.Add(new SqlParameter("@isApartment", job.IsApartment));
            UpdateJobCommand.Parameters.Add(new SqlParameter("@noBoxes", job.NoBoxes));
            UpdateJobCommand.Parameters.Add(new SqlParameter("@selfPacked", job.SelfPacked));
            UpdateJobCommand.Parameters.Add(new SqlParameter("@furnitureAssembly", job.FurnitureAssembly));
            UpdateJobCommand.Parameters.Add(new SqlParameter("@extraRequirements", job.ExtraRequirements));
            UpdateJobCommand.Parameters.Add(new SqlParameter("@price", job.Price));
            UpdateJobCommand.Parameters.Add(new SqlParameter("@amountPaid", job.AmountPaid));
            UpdateJobCommand.Parameters.Add(new SqlParameter("@noWorkers", job.NoWorkers));
            UpdateJobCommand.Parameters.Add(new SqlParameter("@noSmallVans", job.NoSmallVans));
            UpdateJobCommand.Parameters.Add(new SqlParameter("@noMediumVans", job.NoMediumVans));
            UpdateJobCommand.Parameters.Add(new SqlParameter("@noLargeVans", job.NoLargeVans));
            rowsAffected = UpdateJobCommand.ExecuteNonQuery();

            connection.Close();
        }
        DeleteItems(job.ID);
        WriteJobSpecialItems(job.ID, job.SpecialItems);
        return rowsAffected;
    }

    public static void UpdateStaff(Staff staff)
    {
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();
            SqlCommand UpdateStaffCommand = new();

            UpdateStaffCommand.Connection = connection;
            UpdateStaffCommand.CommandType = CommandType.StoredProcedure;
            UpdateStaffCommand.CommandText = "UpdateStaff";


            UpdateStaffCommand.Parameters.Add(new SqlParameter("@username", staff.Username));
            UpdateStaffCommand.Parameters.Add(new SqlParameter("@password", staff.Password));
            UpdateStaffCommand.Parameters.Add(new SqlParameter("@salt", staff.Salt));
            UpdateStaffCommand.Parameters.Add(new SqlParameter("@forename", staff.Forename));
            UpdateStaffCommand.Parameters.Add(new SqlParameter("@surname", staff.Surname));
            UpdateStaffCommand.Parameters.Add(new SqlParameter("@profile", staff.Profile));

            UpdateStaffCommand.ExecuteNonQuery();

            connection.Close();
        }
    }
    #endregion

    #region Delete
    public static int DeleteRecord(string id, string table)
    {
        int rowsAffected;
        if (table == "Job") DeleteItems(id);
        else if (table == "SpecialItem") DeleteJobs(id);
        else if (table == "Customer") DeleteCustomerRecords(id);
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();

            string query = $"DELETE FROM {table} WHERE ID = '{id}'";
            if (table == "SpecialItem") query = $"DELETE FROM {table} WHERE Name = '{id}'";
            if (table == "Staff") query = $"DELETE FROM {table} WHERE Username = '{id}'";
            SqlCommand cmd = new(query, connection);
            rowsAffected = cmd.ExecuteNonQuery();

            connection.Close();
            cmd.Dispose();
        }
        return rowsAffected;
    }

    public static int DeleteItems(string jobID)
    {
        int rowsAffected;
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();

            string query = $"DELETE FROM JobSpecialItem WHERE JobID = '{jobID}'";
            SqlCommand cmd = new(query, connection);
            rowsAffected = cmd.ExecuteNonQuery();

            connection.Close();
            cmd.Dispose();
        }
        return rowsAffected;
    }

    public static int DeleteJobs(string specialItemName)
    {
        int rowsAffected;
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();

            string query = $"DELETE FROM JobSpecialItem WHERE SpecialItemName = '{specialItemName}'";
            SqlCommand cmd = new(query, connection);
            rowsAffected = cmd.ExecuteNonQuery();

            connection.Close();
            cmd.Dispose();
        }
        return rowsAffected;
    }
    public static int DeleteCustomerRecords(string custID)
    {
        int rowsAffected;
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();

            string query = $"DELETE FROM Job WHERE CustomerID = '{custID}'";
            SqlCommand cmd = new(query, connection);
            rowsAffected = cmd.ExecuteNonQuery();

            connection.Close();
            cmd.Dispose();
        }
        using (SqlConnection connection = new(_connectionString))
        {
            connection.Open();

            string query = $"DELETE FROM Inspection WHERE CustomerID = '{custID}'";
            SqlCommand cmd = new(query, connection);
            rowsAffected += cmd.ExecuteNonQuery();

            connection.Close();
            cmd.Dispose();
        }
        return rowsAffected;
    }
    #endregion
}
