using Movers_Booking_System.Models;
using Movers_Booking_System.Tools;
using System.ComponentModel.DataAnnotations;

namespace Movers_Booking_System.Controllers;

public static class CustomerController
{
    private static string errorMessage = "";
    public static string ReadErrorMessage()
    {
        string msg = errorMessage;
        errorMessage = "";
        return msg;
    }
    public static bool ValidateCustomerDetails(Customer cust)
    {
        var emailTool = new EmailAddressAttribute();
        List<Customer> custList = DAL.GetCustomerList();
        foreach (Customer c in custList)
        {
            if (c.TelNo == cust.TelNo)
            {
                errorMessage = "Telephone Number already registered in the database";
                return false;
            }
            if (c.Email == cust.Email)
            {
                errorMessage = "Email Address is already registered in the database";
                return false;
            }
        }
        foreach (char c in cust.TelNo)
        {
            if (!char.IsDigit(c))
            {
                errorMessage = "Telephone number is in an invalid form";
                return false;
            }
        }
        if (cust.TelNo.Length != 11)
        {
            errorMessage = "Telephone number is an invalid length";
            return false;
        }
        if (!emailTool.IsValid(cust.Email))
        {
            errorMessage = "Email is in an invalid format";
            return false;
        }
        return true;
    }
    public static List<string> GetCustomerNames()
    {
        List<Customer> cust = DAL.GetCustomerList();
        List<string> names = new List<string>();
        foreach (Customer c in cust)
        {
            names.Add(c.Forename + " " + c.Surname);
        }
        return names;
    }
    public static string GetCustomerID(int i)
    {
        List<Customer> customer = DAL.GetCustomerList();
        return customer[i].ID;
    }
    public static int GetCustomerIndex(string id)
    {
        List<Customer> customer = DAL.GetCustomerList();
        for (int i = 0; i < customer.Count; i++)
        {
            if (customer[i].ID == id) return i;
        }
        return -1;
    }
    public static string GenerateNewCustID()
    {
        List<string> idList = DAL.GetIDFromTable("Customer");
        List<int> idValues = new List<int>();
        foreach (string id in idList) idValues.Add(Convert.ToInt32(id.Substring(2)));
        int max = 0;
        foreach (int i in idValues) if (i > max) max = i;
        int newIDValue = max + 1;
        string newID = "C-";
        if (newIDValue.ToString().Length == 1) newID += "00";
        else if (newIDValue.ToString().Length == 2) newID += "0";
        newID += newIDValue.ToString();
        return newID;
    }
    public static bool WriteCustomer(Customer cust, bool editMode)
    {
        bool valid = ValidateCustomerDetails(cust);
        if (!valid) return false;
        else
        {
            int rows;
            if (editMode) rows = DAL.UpdateCustomer(cust);
            else rows = DAL.WriteNewCustomer(cust);
            if (rows != 1)
            {
                errorMessage = "Database error, Customer update unsuccessful";
                return false;
            }
            else return true;
        }
    }
}
