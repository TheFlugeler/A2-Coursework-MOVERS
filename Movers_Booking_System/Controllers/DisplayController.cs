namespace Movers_Booking_System.Controllers;

public static class DisplayController
{
    private static MasterForm masterForm;
    public static void SetMasterForm(MasterForm form)
    {
        masterForm = form;
    }
    public static void DisplayForm(Form form) => masterForm.DisplayForm(form);
}