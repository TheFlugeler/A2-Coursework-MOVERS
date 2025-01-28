using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movers_Booking_System.Controllers;

public static class ProfileController
{
    private static Image[] profilePictures = [Image.FromFile("Profiles/Female-Profile-1.png"),
                                Image.FromFile("Profiles/Female-Profile-2.png"),
                                Image.FromFile("Profiles/Female-Profile-3.png"),
                                Image.FromFile("Profiles/Male-Profile-1.png"),
                                Image.FromFile("Profiles/Male-Profile-2.png"),
                                Image.FromFile("Profiles/Male-Profile-3.png")];

    private static string[] filePaths = ["Profiles/Female-Profile-1.png",
                                "Profiles/Female-Profile-2.png",
                                "Profiles/Female-Profile-3.png",
                                "Profiles/Male-Profile-1.png",
                                "Profiles/Male-Profile-2.png",
                                "Profiles/Male-Profile-3.png"];
    public static Image GetProfileImage(int i) => profilePictures[i];
    public static string GetFilePath(int i) => filePaths[i];

}
