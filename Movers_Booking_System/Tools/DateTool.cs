using DateTimeExtensions;

namespace Movers_Booking_System.Tools;

public static class DateTool
{
    private static string errorMessage = string.Empty;
    public static bool IsNonNegotiableHoliday(DateTime date)
    {
        //Checks Christmas Eve, Christmas Day and Boxing Day
        if (date.Month == 12 && (date.Day == 24 || date.Day == 25 || date.Day == 26)) return true;

        //Checks Easter Sunday and Easter Monday
        DateTime easterSunday = EasterSunday(date.Year);
        if (date.Date == easterSunday.Date || date.Date == easterSunday.AddDays(1).Date) return true;

        return false;
    }

    public static bool IsPublicHolidayOrSunday(DateTime date)
    {
        bool isHoliday = false;
        if (date.IsHoliday()) isHoliday = true;
        if (date.DayOfWeek == DayOfWeek.Sunday) isHoliday = true;
        return isHoliday;
    }

    public static string ReadErrorMessage()
    {
        string msg = errorMessage;
        errorMessage = string.Empty;
        return msg;
    }

    //https://www.codeproject.com/Articles/10860/Calculating-Christian-Holidays
    //This code was taken directly from this article
    private static DateTime EasterSunday(int year)
    {
        int day;
        int month;
        //Golden Number
        int g = year % 19;
        //Century
        int c = year / 100;
        //Epact
        int h = (c - (int)(c / 4) - (int)((8 * c + 13) / 25) + 19 * g + 15) % 30;
        //Adjustment for large epact
        int i = h - (int)(h / 28) * (1 - (int)(h / 28) * (int)(29 / (h + 1)) * (int)((21 - g) / 11));

        day = i - ((year + (int)(year / 4) + i + 2 - c + (int)(c / 4)) % 7) + 28;
        month = 3;

        if (day > 31)
        {
            month++;
            day -= 31;
        }
        return new DateTime(year, month, day);
    }
}
