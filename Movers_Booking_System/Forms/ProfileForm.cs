using Movers_Booking_System.Controllers;
using Movers_Booking_System.Models;
using Movers_Booking_System.Tools;

namespace Movers_Booking_System.Forms;

public partial class ProfileForm : Form
{
    private bool newStaff;
    private int selectedProfile = 0;

    public ProfileForm(bool newStaff)
    {
        InitializeComponent();
        if (newStaff)
        {
            labelEditProfile.Text = "Create Staff";
            customButtonSubmit.Text = "Create";
            labelPassword.Visible = true;
            textBoxPassword.Visible = true;
            textBoxPassword.PlaceholderText = "";
            checkBox1.Visible = false;
        }
        else
        {
            Staff staff = DAL.GetStaffDetails(MainForm.StaffUsername);
            textBoxForename.Text = staff.Forename;
            textBoxSurname.Text = staff.Surname;
            textBoxUsername.Text = staff.Username;
            labelPassword.Visible = false;
            textBoxPassword.Visible = false;
            selectedProfile = staff.Profile;
        }
        this.newStaff = newStaff;
        pictureBoxProfile.Image = ProfileController.GetProfileImage(selectedProfile);
    }

    private void buttonRight_Click(object sender, EventArgs e)
    {
        if (selectedProfile < 5) selectedProfile++;
        else selectedProfile = 0;
        pictureBoxProfile.Image = ProfileController.GetProfileImage(selectedProfile);
    }

    private void buttonLeft_Click(object sender, EventArgs e)
    {
        if (selectedProfile > 0) selectedProfile--;
        else selectedProfile = 5;
        pictureBoxProfile.Image = ProfileController.GetProfileImage(selectedProfile);
    }

    private void customButtonSubmit_Click(object sender, EventArgs e)
    {
        if (newStaff)
        {
            List<string> usernames = DAL.GetStaffUsernames();
            if (usernames.Contains(textBoxUsername.Text))
            {
                MessageBox.Show("Username is taken", "Error");
                return;
            }
            List<string> hash = EncryptTool.HashPassword(textBoxPassword.Text);
            Staff staff = new(textBoxUsername.Text, hash[0], hash[1], textBoxForename.Text, textBoxSurname.Text, selectedProfile);
            DAL.WriteNewStaff(staff);
            MessageBox.Show("New Staff login added successfully", "Success");
            DisplayController.DisplayForm(new MainForm());
        }
        else
        {
            List<string> usernames = DAL.GetStaffUsernames();
            usernames.Remove(MainForm.StaffUsername);
            if (usernames.Contains(textBoxUsername.Text))
            {
                MessageBox.Show("Username is taken", "Error");
                return;
            }
            Staff staff = DAL.GetStaffDetails(MainForm.StaffUsername);
            if (checkBox1.Checked)
            {
                List<string> hash = EncryptTool.HashPassword(textBoxPassword.Text);
                staff.Password = hash[0];
                staff.Salt = hash[1];
            }
            staff.Forename = textBoxForename.Text;
            staff.Surname = textBoxSurname.Text;
            staff.Username = textBoxUsername.Text;
            staff.Profile = selectedProfile;
            if (MainForm.StaffUsername != staff.Username)
            {
                DAL.DeleteRecord(MainForm.StaffUsername, "Staff");
                DAL.WriteNewStaff(staff);
            }
            else DAL.UpdateStaff(staff);

            MainForm.StaffUsername = staff.Username;
            MessageBox.Show("Staff details updated successfully", "Success");
            DisplayController.DisplayForm(new MainForm());
        }
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        labelPassword.Visible = checkBox1.Checked;
        textBoxPassword.Visible = checkBox1.Checked;
    }

    private void buttonBack_Click(object sender, EventArgs e) => DisplayController.DisplayForm(new MainForm());

    private void linkLabelNewStaff_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => DisplayController.DisplayForm(new ProfileForm(true));
}
