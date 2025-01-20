using Movers_Booking_System.Forms;
namespace Movers_Booking_System;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        SetupDatabasePath();
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new LoadingForm());

    }
    static void SetupDatabasePath()
    {
        string outputDirPath = Path.GetDirectoryName(Application.ExecutablePath);
        string fullPath = Path.GetFullPath(Path.Combine(outputDirPath, @"..\..\..\Database\MoversDatabase.mdf"));
        AppDomain.CurrentDomain.SetData("DataDirectory", fullPath);
    }
}