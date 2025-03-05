namespace Movers_Booking_System.Tools;

public static class ValidationTool
{
    public static string errorMessage;
    public static bool ContainsOnlyLetters(string str)
    {
        foreach(char c in str) if(!char.IsLetter(c)) return false;
        return true;
    }

    public static bool ContainsOnlyLettersAndWhitespace(string str)
    {
        foreach (char c in str) if (!char.IsLetter(c) && !char.IsWhiteSpace(c)) return false;
        return true;
    }

    public static bool ContainsOnlyLettersAndNumbers(string str)
    {
        foreach (char c in str) if (!char.IsLetterOrDigit(c)) return false;
        return true;
    }

    public static bool ContainsOnlyLettersNumbersAndPunctuation(string str)
    {
        foreach (char c in str) if (!char.IsLetterOrDigit(c) && !char.IsPunctuation(c) && !char.IsWhiteSpace(c)) return false;
        return true;
    }
    public static bool IsSecurePassword(string password)
    {
        if (password.Length < 10)
        {
            errorMessage = "Password is too short";
            return false;
        }
        int noNumbers = 0;
        int noSpecial = 0;
        int noUppercase = 0;
        int noLowercase = 0;
        foreach (char c in password)
        {
            if (char.IsLower(c)) noLowercase++;
            else if (char.IsUpper(c)) noUppercase++;
            else if (char.IsDigit(c)) noNumbers++;
            else noSpecial++;
            if (char.IsWhiteSpace(c))
            {
                errorMessage = "Password cannot contain whitespace";
                return false;
            }
        }
        if (noNumbers < 1)
        {
            errorMessage = "Password must contain at least one number";
            return false;
        }if (noSpecial < 1)
        {
            errorMessage = "Passord must contain at least one special character";
            return false;
        }if (noUppercase < 1)
        {
            errorMessage = "Password must contain at least one capital letter";
            return false;
        }if (noLowercase < 1)
        {
            errorMessage = "Password must contain at least one lowercase letter";
            return false;
        }
        return true;
    }

    public static string ReadErrorMessage()
    {
        string msg = errorMessage;
        errorMessage = "";
        return msg;
    }
}
