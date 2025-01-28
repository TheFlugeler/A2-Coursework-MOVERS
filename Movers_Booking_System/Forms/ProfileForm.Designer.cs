namespace Movers_Booking_System.Forms
{
    partial class ProfileForm
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
            panelTopBar = new Panel();
            buttonBack = new Button();
            labelProfile = new Label();
            panelLogo = new Panel();
            panelForm = new Panel();
            checkBox1 = new CheckBox();
            buttonRight = new Button();
            buttonLeft = new Button();
            pictureBoxProfile = new PictureBox();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            textBoxForename = new TextBox();
            textBoxUsername = new TextBox();
            labelUsername = new Label();
            textBoxSurname = new TextBox();
            labelSurname = new Label();
            labelForename = new Label();
            labelEditProfile = new Label();
            customButtonSubmit = new CustControlLib.CustomButton();
            linkLabelNewStaff = new LinkLabel();
            panelTopBar.SuspendLayout();
            panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            SuspendLayout();
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = Color.FromArgb(19, 21, 39);
            panelTopBar.Controls.Add(buttonBack);
            panelTopBar.Controls.Add(labelProfile);
            panelTopBar.Controls.Add(panelLogo);
            panelTopBar.Dock = DockStyle.Top;
            panelTopBar.Location = new Point(0, 0);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(1262, 100);
            panelTopBar.TabIndex = 5;
            // 
            // buttonBack
            // 
            buttonBack.BackgroundImage = Media.SystemImages.back_button;
            buttonBack.BackgroundImageLayout = ImageLayout.Zoom;
            buttonBack.FlatAppearance.BorderSize = 0;
            buttonBack.FlatStyle = FlatStyle.Flat;
            buttonBack.Font = new Font("Bahnschrift", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBack.ForeColor = Color.White;
            buttonBack.Location = new Point(1180, 20);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(60, 60);
            buttonBack.TabIndex = 6;
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // labelProfile
            // 
            labelProfile.AutoSize = true;
            labelProfile.Font = new Font("Bahnschrift", 24F, FontStyle.Bold);
            labelProfile.ForeColor = Color.White;
            labelProfile.Location = new Point(180, 25);
            labelProfile.Name = "labelProfile";
            labelProfile.Size = new Size(236, 48);
            labelProfile.TabIndex = 3;
            labelProfile.Text = "User Profile";
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
            // panelForm
            // 
            panelForm.BackColor = Color.FromArgb(30, 125, 187);
            panelForm.Controls.Add(checkBox1);
            panelForm.Controls.Add(buttonRight);
            panelForm.Controls.Add(buttonLeft);
            panelForm.Controls.Add(pictureBoxProfile);
            panelForm.Controls.Add(labelPassword);
            panelForm.Controls.Add(textBoxPassword);
            panelForm.Controls.Add(textBoxForename);
            panelForm.Controls.Add(textBoxUsername);
            panelForm.Controls.Add(labelUsername);
            panelForm.Controls.Add(textBoxSurname);
            panelForm.Controls.Add(labelSurname);
            panelForm.Controls.Add(labelForename);
            panelForm.Controls.Add(labelEditProfile);
            panelForm.Location = new Point(351, 192);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(560, 445);
            panelForm.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Bahnschrift", 14F);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(200, 292);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(238, 33);
            checkBox1.TabIndex = 21;
            checkBox1.Text = "Set New Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // buttonRight
            // 
            buttonRight.BackgroundImage = Media.SystemImages.right_arrow;
            buttonRight.BackgroundImageLayout = ImageLayout.Zoom;
            buttonRight.FlatAppearance.BorderSize = 0;
            buttonRight.FlatStyle = FlatStyle.Flat;
            buttonRight.Font = new Font("Bahnschrift", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRight.ForeColor = Color.White;
            buttonRight.Location = new Point(330, 365);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(30, 30);
            buttonRight.TabIndex = 20;
            buttonRight.UseVisualStyleBackColor = true;
            buttonRight.Click += buttonRight_Click;
            // 
            // buttonLeft
            // 
            buttonLeft.BackgroundImage = Media.SystemImages.left_arrow;
            buttonLeft.BackgroundImageLayout = ImageLayout.Zoom;
            buttonLeft.FlatAppearance.BorderSize = 0;
            buttonLeft.FlatStyle = FlatStyle.Flat;
            buttonLeft.Font = new Font("Bahnschrift", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLeft.ForeColor = Color.White;
            buttonLeft.Location = new Point(220, 365);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(30, 30);
            buttonLeft.TabIndex = 19;
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += buttonLeft_Click;
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.Location = new Point(250, 340);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(80, 80);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProfile.TabIndex = 17;
            pictureBoxProfile.TabStop = false;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Bahnschrift", 14F);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(75, 249);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(119, 29);
            labelPassword.TabIndex = 16;
            labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Bahnschrift", 12F);
            textBoxPassword.Location = new Point(200, 249);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Input New Password";
            textBoxPassword.Size = new Size(296, 32);
            textBoxPassword.TabIndex = 4;
            // 
            // textBoxForename
            // 
            textBoxForename.Font = new Font("Bahnschrift", 12F);
            textBoxForename.Location = new Point(200, 147);
            textBoxForename.Name = "textBoxForename";
            textBoxForename.Size = new Size(296, 32);
            textBoxForename.TabIndex = 1;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Bahnschrift", 12F);
            textBoxUsername.Location = new Point(200, 96);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(296, 32);
            textBoxUsername.TabIndex = 3;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Bahnschrift", 14F);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(70, 96);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(124, 29);
            labelUsername.TabIndex = 8;
            labelUsername.Text = "Username";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Font = new Font("Bahnschrift", 12F);
            textBoxSurname.Location = new Point(200, 198);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(296, 32);
            textBoxSurname.TabIndex = 2;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Bahnschrift", 14F);
            labelSurname.ForeColor = Color.White;
            labelSurname.Location = new Point(83, 198);
            labelSurname.Name = "labelSurname";
            labelSurname.Size = new Size(111, 29);
            labelSurname.TabIndex = 6;
            labelSurname.Text = "Surname";
            // 
            // labelForename
            // 
            labelForename.AutoSize = true;
            labelForename.Font = new Font("Bahnschrift", 14F);
            labelForename.ForeColor = Color.White;
            labelForename.Location = new Point(72, 147);
            labelForename.Name = "labelForename";
            labelForename.Size = new Size(122, 29);
            labelForename.TabIndex = 4;
            labelForename.Text = "Forename";
            // 
            // labelEditProfile
            // 
            labelEditProfile.AutoSize = true;
            labelEditProfile.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
            labelEditProfile.ForeColor = Color.White;
            labelEditProfile.Location = new Point(20, 24);
            labelEditProfile.Name = "labelEditProfile";
            labelEditProfile.Size = new Size(187, 41);
            labelEditProfile.TabIndex = 3;
            labelEditProfile.Text = "Edit Profile";
            // 
            // customButtonSubmit
            // 
            customButtonSubmit.BackColor = Color.FromArgb(30, 125, 187);
            customButtonSubmit.BorderColor = Color.Black;
            customButtonSubmit.BorderRadius = 40;
            customButtonSubmit.BorderWidth = 0;
            customButtonSubmit.FlatAppearance.BorderSize = 0;
            customButtonSubmit.FlatStyle = FlatStyle.Flat;
            customButtonSubmit.Font = new Font("Bahnschrift SemiBold", 12F, FontStyle.Bold);
            customButtonSubmit.ForeColor = Color.White;
            customButtonSubmit.Location = new Point(792, 643);
            customButtonSubmit.Name = "customButtonSubmit";
            customButtonSubmit.Size = new Size(119, 49);
            customButtonSubmit.TabIndex = 7;
            customButtonSubmit.Text = "Submit";
            customButtonSubmit.UseVisualStyleBackColor = false;
            customButtonSubmit.Click += customButtonSubmit_Click;
            // 
            // linkLabelNewStaff
            // 
            linkLabelNewStaff.ActiveLinkColor = Color.Silver;
            linkLabelNewStaff.AutoSize = true;
            linkLabelNewStaff.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabelNewStaff.LinkColor = Color.White;
            linkLabelNewStaff.Location = new Point(539, 643);
            linkLabelNewStaff.Name = "linkLabelNewStaff";
            linkLabelNewStaff.Size = new Size(217, 24);
            linkLabelNewStaff.TabIndex = 8;
            linkLabelNewStaff.TabStop = true;
            linkLabelNewStaff.Text = "Create New Staff Login";
            linkLabelNewStaff.VisitedLinkColor = Color.White;
            linkLabelNewStaff.LinkClicked += linkLabelNewStaff_LinkClicked;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 68, 102);
            ClientSize = new Size(1262, 744);
            Controls.Add(linkLabelNewStaff);
            Controls.Add(customButtonSubmit);
            Controls.Add(panelForm);
            Controls.Add(panelTopBar);
            Name = "ProfileForm";
            Text = "ProfileForm";
            panelTopBar.ResumeLayout(false);
            panelTopBar.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTopBar;
        private Button buttonBack;
        private Label labelProfile;
        private Panel panelLogo;
        private Panel panelForm;
        private TextBox textBoxForename;
        private TextBox textBoxUsername;
        private Label labelUsername;
        private TextBox textBoxSurname;
        private Label labelSurname;
        private Label labelForename;
        private Label labelEditProfile;
        private CustControlLib.CustomButton customButtonSubmit;
        private PictureBox pictureBoxProfile;
        private Button buttonRight;
        private Button buttonLeft;
        private CheckBox checkBox1;
        private Label labelPassword;
        private TextBox textBoxPassword;
        private LinkLabel linkLabelNewStaff;
    }
}