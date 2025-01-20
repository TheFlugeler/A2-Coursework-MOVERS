using Movers_Booking_System.Controllers;

namespace Movers_Booking_System.Forms;
public partial class LoginForm : Form
{
    public LoginForm()
    {
        InitializeComponent();
        buttonPasswordVisibility.BackgroundImage = Image.FromFile("Media/NotVisible.png");
    }
    private void buttonPasswordVisibility_Click(object sender, EventArgs e)
    {
        if (textBoxPassword.PasswordChar == '*')
        {
            textBoxPassword.PasswordChar = '\0';
            buttonPasswordVisibility.BackgroundImage = Image.FromFile("Media/Visible.png");
        }
        else
        {
            textBoxPassword.PasswordChar = '*';
            buttonPasswordVisibility.BackgroundImage = Image.FromFile("Media/NotVisible.png");
        }
    }

    private void customButtonLogin_Click(object sender, EventArgs e)
    {
        customButtonLogin.Text = "• • •";
        Application.DoEvents();
        if (LoginController.ValidateLoginDetails(textBoxUsername.Text, textBoxPassword.Text))
        {
            DisplayController.DisplayForm(new MainForm());
        }
        else MessageBox.Show("Incorrect User Details", "Error");
        customButtonLogin.Text = "LOGIN";
    }

    private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == 13)
        {
            customButtonLogin_Click(sender, e);
            e.Handled = true;
        }
        else e.Handled = false;
    }
}