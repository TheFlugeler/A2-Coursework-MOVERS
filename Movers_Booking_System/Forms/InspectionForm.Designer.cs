namespace Movers_Booking_System.Forms
{
    partial class InspectionForm
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
            labelInspection = new Label();
            panelLogo = new Panel();
            panelForm = new Panel();
            checkBoxPaid = new CheckBox();
            labelPaid = new Label();
            dateTimePickerDate = new DateTimePicker();
            labelDate = new Label();
            textBoxNewAddress = new TextBox();
            labelNewAddress = new Label();
            textBoxOldAddress = new TextBox();
            labelOldAddress = new Label();
            comboBoxCustomer = new ComboBox();
            labelCustomer = new Label();
            labelBookInspection = new Label();
            customButtonSubmit = new CustControlLib.CustomButton();
            panelTopBar.SuspendLayout();
            panelForm.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = Color.FromArgb(19, 21, 39);
            panelTopBar.Controls.Add(buttonBack);
            panelTopBar.Controls.Add(labelInspection);
            panelTopBar.Controls.Add(panelLogo);
            panelTopBar.Dock = DockStyle.Top;
            panelTopBar.Location = new Point(0, 0);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(1262, 100);
            panelTopBar.TabIndex = 3;
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
            buttonBack.TabIndex = 7;
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // labelInspection
            // 
            labelInspection.AutoSize = true;
            labelInspection.Font = new Font("Bahnschrift", 24F, FontStyle.Bold);
            labelInspection.ForeColor = Color.White;
            labelInspection.Location = new Point(180, 25);
            labelInspection.Name = "labelInspection";
            labelInspection.Size = new Size(310, 48);
            labelInspection.TabIndex = 3;
            labelInspection.Text = "Inspection Form";
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
            panelForm.Controls.Add(checkBoxPaid);
            panelForm.Controls.Add(labelPaid);
            panelForm.Controls.Add(dateTimePickerDate);
            panelForm.Controls.Add(labelDate);
            panelForm.Controls.Add(textBoxNewAddress);
            panelForm.Controls.Add(labelNewAddress);
            panelForm.Controls.Add(textBoxOldAddress);
            panelForm.Controls.Add(labelOldAddress);
            panelForm.Controls.Add(comboBoxCustomer);
            panelForm.Controls.Add(labelCustomer);
            panelForm.Controls.Add(labelBookInspection);
            panelForm.Location = new Point(352, 200);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(575, 350);
            panelForm.TabIndex = 4;
            // 
            // checkBoxPaid
            // 
            checkBoxPaid.AutoSize = true;
            checkBoxPaid.Font = new Font("Bahnschrift", 12F);
            checkBoxPaid.Location = new Point(224, 294);
            checkBoxPaid.Name = "checkBoxPaid";
            checkBoxPaid.Size = new Size(18, 17);
            checkBoxPaid.TabIndex = 5;
            checkBoxPaid.UseVisualStyleBackColor = true;
            // 
            // labelPaid
            // 
            labelPaid.AutoSize = true;
            labelPaid.Font = new Font("Bahnschrift", 14F);
            labelPaid.ForeColor = Color.White;
            labelPaid.Location = new Point(141, 285);
            labelPaid.Name = "labelPaid";
            labelPaid.Size = new Size(59, 29);
            labelPaid.TabIndex = 12;
            labelPaid.Text = "Paid";
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Font = new Font("Bahnschrift", 12F);
            dateTimePickerDate.Location = new Point(224, 240);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(297, 32);
            dateTimePickerDate.TabIndex = 4;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Bahnschrift", 14F);
            labelDate.ForeColor = Color.White;
            labelDate.Location = new Point(137, 240);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(63, 29);
            labelDate.TabIndex = 10;
            labelDate.Text = "Date";
            // 
            // textBoxNewAddress
            // 
            textBoxNewAddress.Font = new Font("Bahnschrift", 12F);
            textBoxNewAddress.Location = new Point(224, 190);
            textBoxNewAddress.Name = "textBoxNewAddress";
            textBoxNewAddress.Size = new Size(297, 32);
            textBoxNewAddress.TabIndex = 3;
            // 
            // labelNewAddress
            // 
            labelNewAddress.AutoSize = true;
            labelNewAddress.Font = new Font("Bahnschrift", 14F);
            labelNewAddress.ForeColor = Color.White;
            labelNewAddress.Location = new Point(43, 190);
            labelNewAddress.Name = "labelNewAddress";
            labelNewAddress.Size = new Size(157, 29);
            labelNewAddress.TabIndex = 8;
            labelNewAddress.Text = "New Address";
            // 
            // textBoxOldAddress
            // 
            textBoxOldAddress.Font = new Font("Bahnschrift", 12F);
            textBoxOldAddress.Location = new Point(224, 140);
            textBoxOldAddress.Name = "textBoxOldAddress";
            textBoxOldAddress.Size = new Size(297, 32);
            textBoxOldAddress.TabIndex = 2;
            // 
            // labelOldAddress
            // 
            labelOldAddress.AutoSize = true;
            labelOldAddress.Font = new Font("Bahnschrift", 14F);
            labelOldAddress.ForeColor = Color.White;
            labelOldAddress.Location = new Point(57, 140);
            labelOldAddress.Name = "labelOldAddress";
            labelOldAddress.Size = new Size(143, 29);
            labelOldAddress.TabIndex = 6;
            labelOldAddress.Text = "Old Address";
            // 
            // comboBoxCustomer
            // 
            comboBoxCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCustomer.Font = new Font("Bahnschrift", 12F);
            comboBoxCustomer.FormattingEnabled = true;
            comboBoxCustomer.Location = new Point(224, 90);
            comboBoxCustomer.Name = "comboBoxCustomer";
            comboBoxCustomer.Size = new Size(297, 32);
            comboBoxCustomer.TabIndex = 1;
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Font = new Font("Bahnschrift", 14F);
            labelCustomer.ForeColor = Color.White;
            labelCustomer.Location = new Point(82, 90);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(118, 29);
            labelCustomer.TabIndex = 4;
            labelCustomer.Text = "Customer";
            // 
            // labelBookInspection
            // 
            labelBookInspection.AutoSize = true;
            labelBookInspection.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
            labelBookInspection.ForeColor = Color.White;
            labelBookInspection.Location = new Point(17, 21);
            labelBookInspection.Name = "labelBookInspection";
            labelBookInspection.Size = new Size(308, 41);
            labelBookInspection.TabIndex = 3;
            labelBookInspection.Text = "Inpsection Booking";
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
            customButtonSubmit.Location = new Point(822, 556);
            customButtonSubmit.Name = "customButtonSubmit";
            customButtonSubmit.Size = new Size(105, 49);
            customButtonSubmit.TabIndex = 6;
            customButtonSubmit.Text = "Submit";
            customButtonSubmit.UseVisualStyleBackColor = false;
            customButtonSubmit.Click += customButtonSubmit_Click;
            // 
            // InspectionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 68, 102);
            ClientSize = new Size(1262, 744);
            Controls.Add(customButtonSubmit);
            Controls.Add(panelForm);
            Controls.Add(panelTopBar);
            Name = "InspectionForm";
            Text = "InspectionForm";
            panelTopBar.ResumeLayout(false);
            panelTopBar.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopBar;
        private Panel panelLogo;
        private Label labelInspection;
        private Button buttonBack;
        private Panel panelForm;
        private Label labelBookInspection;
        private Label labelCustomer;
        private Label labelOldAddress;
        private ComboBox comboBoxCustomer;
        private Label labelDate;
        private TextBox textBoxNewAddress;
        private Label labelNewAddress;
        private TextBox textBoxOldAddress;
        private CheckBox checkBoxPaid;
        private Label labelPaid;
        private DateTimePicker dateTimePickerDate;
        private CustControlLib.CustomButton customButtonSubmit;
    }
}