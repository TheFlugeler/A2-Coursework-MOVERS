namespace Movers_Booking_System.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            customPanelLoginPortal = new CustControlLib.CustomPanel();
            buttonPasswordVisibility = new Button();
            customButtonLogin = new CustControlLib.CustomButton();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            labelUsername = new Label();
            textBoxUsername = new TextBox();
            labelLogin = new Label();
            panelLogo = new Panel();
            panelTopBar = new Panel();
            labelWelcome = new Label();
            customPanelLoginPortal.SuspendLayout();
            panelTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // customPanelLoginPortal
            // 
            customPanelLoginPortal.BackColor = Color.FromArgb(233, 229, 212);
            customPanelLoginPortal.BackgroundImageLayout = ImageLayout.Center;
            customPanelLoginPortal.BorderColor = Color.Black;
            customPanelLoginPortal.BorderRadius = 40;
            customPanelLoginPortal.BorderWidth = 0;
            customPanelLoginPortal.Controls.Add(buttonPasswordVisibility);
            customPanelLoginPortal.Controls.Add(customButtonLogin);
            customPanelLoginPortal.Controls.Add(labelPassword);
            customPanelLoginPortal.Controls.Add(textBoxPassword);
            customPanelLoginPortal.Controls.Add(labelUsername);
            customPanelLoginPortal.Controls.Add(textBoxUsername);
            customPanelLoginPortal.Controls.Add(labelLogin);
            customPanelLoginPortal.ForeColor = Color.Black;
            customPanelLoginPortal.Location = new Point(460, 200);
            customPanelLoginPortal.Name = "customPanelLoginPortal";
            customPanelLoginPortal.Size = new Size(360, 320);
            customPanelLoginPortal.TabIndex = 0;
            // 
            // buttonPasswordVisibility
            // 
            buttonPasswordVisibility.BackColor = SystemColors.Window;
            buttonPasswordVisibility.BackgroundImageLayout = ImageLayout.Stretch;
            buttonPasswordVisibility.FlatAppearance.BorderSize = 0;
            buttonPasswordVisibility.FlatStyle = FlatStyle.Flat;
            buttonPasswordVisibility.Location = new Point(294, 194);
            buttonPasswordVisibility.Name = "buttonPasswordVisibility";
            buttonPasswordVisibility.Size = new Size(30, 28);
            buttonPasswordVisibility.TabIndex = 8;
            buttonPasswordVisibility.UseVisualStyleBackColor = false;
            buttonPasswordVisibility.Click += buttonPasswordVisibility_Click;
            // 
            // customButtonLogin
            // 
            customButtonLogin.BackColor = Color.FromArgb(30, 125, 187);
            customButtonLogin.BorderColor = Color.Black;
            customButtonLogin.BorderRadius = 40;
            customButtonLogin.BorderWidth = 0;
            customButtonLogin.FlatAppearance.BorderSize = 0;
            customButtonLogin.FlatStyle = FlatStyle.Flat;
            customButtonLogin.Font = new Font("Bahnschrift", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customButtonLogin.ForeColor = Color.FromArgb(233, 229, 212);
            customButtonLogin.Location = new Point(100, 254);
            customButtonLogin.Name = "customButtonLogin";
            customButtonLogin.Size = new Size(160, 38);
            customButtonLogin.TabIndex = 7;
            customButtonLogin.Text = "LOGIN";
            customButtonLogin.UseVisualStyleBackColor = false;
            customButtonLogin.Click += customButtonLogin_Click;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            labelPassword.ForeColor = Color.FromArgb(19, 21, 39);
            labelPassword.Location = new Point(25, 166);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(113, 24);
            labelPassword.TabIndex = 6;
            labelPassword.Text = "PASSWORD";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Bahnschrift", 12F);
            textBoxPassword.ForeColor = Color.Black;
            textBoxPassword.Location = new Point(25, 193);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(300, 32);
            textBoxPassword.TabIndex = 5;
            textBoxPassword.KeyPress += textBoxPassword_KeyPress;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Bahnschrift", 12F, FontStyle.Bold);
            labelUsername.ForeColor = Color.FromArgb(19, 21, 39);
            labelUsername.Location = new Point(25, 85);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(115, 24);
            labelUsername.TabIndex = 4;
            labelUsername.Text = "USERNAME";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Bahnschrift", 12F);
            textBoxUsername.ForeColor = Color.Black;
            textBoxUsername.Location = new Point(25, 112);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(300, 32);
            textBoxUsername.TabIndex = 1;
            // 
            // labelLogin
            // 
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
            labelLogin.ForeColor = Color.FromArgb(30, 125, 187);
            labelLogin.Location = new Point(20, 25);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(112, 41);
            labelLogin.TabIndex = 0;
            labelLogin.Text = "LOGIN";
            // 
            // panelLogo
            // 
            panelLogo.BackgroundImage = Media.SystemImages.MOVERS_Logo___Dark;
            panelLogo.BackgroundImageLayout = ImageLayout.Stretch;
            panelLogo.Location = new Point(0, -40);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(180, 180);
            panelLogo.TabIndex = 0;
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = Color.FromArgb(19, 21, 39);
            panelTopBar.Controls.Add(labelWelcome);
            panelTopBar.Controls.Add(panelLogo);
            panelTopBar.Dock = DockStyle.Top;
            panelTopBar.Location = new Point(0, 0);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(1262, 100);
            panelTopBar.TabIndex = 3;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Bahnschrift", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelWelcome.ForeColor = Color.White;
            labelWelcome.Location = new Point(180, 25);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(393, 48);
            labelWelcome.TabIndex = 1;
            labelWelcome.Text = "Welcome to MOVERS";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 68, 102);
            ClientSize = new Size(1262, 744);
            Controls.Add(panelTopBar);
            Controls.Add(customPanelLoginPortal);
            Name = "LoginForm";
            Text = "LoginForm";
            customPanelLoginPortal.ResumeLayout(false);
            customPanelLoginPortal.PerformLayout();
            panelTopBar.ResumeLayout(false);
            panelTopBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CustControlLib.CustomPanel customPanelLoginPortal;
        private TextBox textBoxUsername;
        private Label labelLogin;
        private CustControlLib.CustomButton customButtonLogin;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private Label labelUsername;
        private Button buttonPasswordVisibility;
        private Panel panelLogo;
        private Panel panelTopBar;
        private Label labelWelcome;
    }
}