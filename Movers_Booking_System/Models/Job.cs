namespace Movers_Booking_System.Models;
public class Job
{
    public string ID { get; set; }
    public string CustomerID { get; set; }
    public DateTime EstimateDate { get; set; }
    public bool Confirmed { get; set; }
    public DateTime JobDate { get; set; }
    public string OldAddress { get; set; }
    public string NewAddress { get; set; }
    public int NoRooms { get; set; }
    public bool IsApartment { get; set; }
    public int NoBoxes { get; set; }
    public bool SelfPacked { get; set; }
    public bool FurnitureAssembly { get; set; }
    public string ExtraRequirements { get; set; }
    public double Price { get; set; }
    public double AmountPaid { get; set; }
    public int NoWorkers { get; set; }
    public int NoSmallVans { get; set; }
    public int NoMediumVans { get; set; }
    public int NoLargeVans { get; set; }
    public List<SpecialItem> SpecialItems { get; set; }

    public Job(
        string id, string customerID, DateTime estimateDate, bool confirmed,
        DateTime jobDate, string oldAddress, string newAddress, int noRooms,
        bool isApartment, int noBoxes, bool selfPacked, bool furnitureAssembly,
        string extraRequirements, double price, double amountPaid, int noWorkers, int noSmallVans,
        int noMediumVans, int noLargeVans, List<SpecialItem> specialItems)
    {
        ID = id;
        CustomerID = customerID;
        EstimateDate = estimateDate;
        Confirmed = confirmed;
        JobDate = jobDate;
        OldAddress = oldAddress;
        NewAddress = newAddress;
        NoRooms = noRooms;
        IsApartment = isApartment;
        NoBoxes = noBoxes;
        SelfPacked = selfPacked;
        FurnitureAssembly = furnitureAssembly;
        ExtraRequirements = extraRequirements;
        Price = price;
        AmountPaid = amountPaid;
        NoWorkers = noWorkers;
        NoSmallVans = noSmallVans;
        NoMediumVans = noMediumVans;
        NoLargeVans = noLargeVans;
        SpecialItems = specialItems;
    }
}
