namespace Movers_Booking_System.Forms
{
    partial class CustomerForm
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
            labelCustomer = new Label();
            panelLogo = new Panel();
            panelFormArea = new Panel();
            customButtonSubmit = new CustControlLib.CustomButton();
            panelForm = new Panel();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            textBoxForename = new TextBox();
            textBoxTelNo = new TextBox();
            labelTelNo = new Label();
            textBoxSurname = new TextBox();
            labelSurname = new Label();
            labelForename = new Label();
            labelCreateCustomer = new Label();
            panelTopBar.SuspendLayout();
            panelFormArea.SuspendLayout();
            panelForm.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = Color.FromArgb(19, 21, 39);
            panelTopBar.Controls.Add(buttonBack);
            panelTopBar.Controls.Add(labelCustomer);
            panelTopBar.Controls.Add(panelLogo);
            panelTopBar.Dock = DockStyle.Top;
            panelTopBar.Location = new Point(0, 0);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(1262, 100);
            panelTopBar.TabIndex = 4;
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
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Font = new Font("Bahnschrift", 24F, FontStyle.Bold);
            labelCustomer.ForeColor = Color.White;
            labelCustomer.Location = new Point(180, 25);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(301, 48);
            labelCustomer.TabIndex = 3;
            labelCustomer.Text = "Customer Form";
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
            // panelFormArea
            // 
            panelFormArea.AutoScroll = true;
            panelFormArea.Controls.Add(customButtonSubmit);
            panelFormArea.Controls.Add(panelForm);
            panelFormArea.Dock = DockStyle.Fill;
            panelFormArea.Location = new Point(0, 100);
            panelFormArea.Name = "panelFormArea";
            panelFormArea.Size = new Size(1262, 644);
            panelFormArea.TabIndex = 5;
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
            customButtonSubmit.Location = new Point(801, 477);
            customButtonSubmit.Name = "customButtonSubmit";
            customButtonSubmit.Size = new Size(119, 53);
            customButtonSubmit.TabIndex = 5;
            customButtonSubmit.Text = "Submit";
            customButtonSubmit.UseVisualStyleBackColor = false;
            customButtonSubmit.Click += customButtonSubmit_Click;
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.FromArgb(30, 125, 187);
            panelForm.Controls.Add(labelEmail);
            panelForm.Controls.Add(textBoxEmail);
            panelForm.Controls.Add(textBoxForename);
            panelForm.Controls.Add(textBoxTelNo);
            panelForm.Controls.Add(labelTelNo);
            panelForm.Controls.Add(textBoxSurname);
            panelForm.Controls.Add(labelSurname);
            panelForm.Controls.Add(labelForename);
            panelForm.Controls.Add(labelCreateCustomer);
            panelForm.Location = new Point(360, 100);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(560, 360);
            panelForm.TabIndex = 5;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Bahnschrift", 14F);
            labelEmail.ForeColor = Color.White;
            labelEmail.Location = new Point(113, 248);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(74, 29);
            labelEmail.TabIndex = 16;
            labelEmail.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Font = new Font("Bahnschrift", 12F);
            textBoxEmail.Location = new Point(200, 248);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "eg. example@test.com";
            textBoxEmail.Size = new Size(296, 32);
            textBoxEmail.TabIndex = 4;
            // 
            // textBoxForename
            // 
            textBoxForename.Font = new Font("Bahnschrift", 12F);
            textBoxForename.Location = new Point(200, 89);
            textBoxForename.Name = "textBoxForename";
            textBoxForename.Size = new Size(296, 32);
            textBoxForename.TabIndex = 1;
            // 
            // textBoxTelNo
            // 
            textBoxTelNo.Font = new Font("Bahnschrift", 12F);
            textBoxTelNo.Location = new Point(200, 195);
            textBoxTelNo.Name = "textBoxTelNo";
            textBoxTelNo.PlaceholderText = "eg. 07123456789";
            textBoxTelNo.Size = new Size(296, 32);
            textBoxTelNo.TabIndex = 3;
            // 
            // labelTelNo
            // 
            labelTelNo.AutoSize = true;
            labelTelNo.Font = new Font("Bahnschrift", 14F);
            labelTelNo.ForeColor = Color.White;
            labelTelNo.Location = new Point(37, 195);
            labelTelNo.Name = "labelTelNo";
            labelTelNo.Size = new Size(163, 29);
            labelTelNo.TabIndex = 8;
            labelTelNo.Text = "Telephone No.";
            // 
            // textBoxSurname
            // 
            textBoxSurname.Font = new Font("Bahnschrift", 12F);
            textBoxSurname.Location = new Point(200, 142);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(296, 32);
            textBoxSurname.TabIndex = 2;
            // 
            // labelSurname
            // 
            labelSurname.AutoSize = true;
            labelSurname.Font = new Font("Bahnschrift", 14F);
            labelSurname.ForeColor = Color.White;
            labelSurname.Location = new Point(82, 142);
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
            labelForename.Location = new Point(72, 89);
            labelForename.Name = "labelForename";
            labelForename.Size = new Size(122, 29);
            labelForename.TabIndex = 4;
            labelForename.Text = "Forename";
            // 
            // labelCreateCustomer
            // 
            labelCreateCustomer.AutoSize = true;
            labelCreateCustomer.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
            labelCreateCustomer.ForeColor = Color.White;
            labelCreateCustomer.Location = new Point(20, 20);
            labelCreateCustomer.Name = "labelCreateCustomer";
            labelCreateCustomer.Size = new Size(305, 41);
            labelCreateCustomer.TabIndex = 3;
            labelCreateCustomer.Text = "Register Customer";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 68, 102);
            ClientSize = new Size(1262, 744);
            Controls.Add(panelFormArea);
            Controls.Add(panelTopBar);
            Name = "CustomerForm";
            Text = "CustomerForm";
            panelTopBar.ResumeLayout(false);
            panelTopBar.PerformLayout();
            panelFormArea.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopBar;
        private Button buttonBack;
        private Label labelCustomer;
        private Panel panelLogo;
        private Panel panelFormArea;
        private Panel panelForm;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private TextBox textBoxForename;
        private TextBox textBoxTelNo;
        private Label labelTelNo;
        private TextBox textBoxSurname;
        private Label labelSurname;
        private Label labelForename;
        private Label labelCreateCustomer;
        private CustControlLib.CustomButton customButtonSubmit;
    }
}