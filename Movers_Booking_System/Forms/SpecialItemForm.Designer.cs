namespace Movers_Booking_System.Forms
{
    partial class SpecialItemForm
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
            labelSpecialItem = new Label();
            panelLogo = new Panel();
            panelForm = new Panel();
            numericUpDownWorkers = new NumericUpDown();
            labelWorkers = new Label();
            label1 = new Label();
            textBoxPrice = new TextBox();
            textBoxName = new TextBox();
            labelTelNo = new Label();
            labelForename = new Label();
            labelCreateSpecialItem = new Label();
            customButtonSubmit = new CustControlLib.CustomButton();
            panelTopBar.SuspendLayout();
            panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWorkers).BeginInit();
            SuspendLayout();
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = Color.FromArgb(19, 21, 39);
            panelTopBar.Controls.Add(buttonBack);
            panelTopBar.Controls.Add(labelSpecialItem);
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
            // labelSpecialItem
            // 
            labelSpecialItem.AutoSize = true;
            labelSpecialItem.Font = new Font("Bahnschrift", 24F, FontStyle.Bold);
            labelSpecialItem.ForeColor = Color.White;
            labelSpecialItem.Location = new Point(180, 25);
            labelSpecialItem.Name = "labelSpecialItem";
            labelSpecialItem.Size = new Size(347, 48);
            labelSpecialItem.TabIndex = 3;
            labelSpecialItem.Text = "Special Item Form";
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
            panelForm.Controls.Add(numericUpDownWorkers);
            panelForm.Controls.Add(labelWorkers);
            panelForm.Controls.Add(label1);
            panelForm.Controls.Add(textBoxPrice);
            panelForm.Controls.Add(textBoxName);
            panelForm.Controls.Add(labelTelNo);
            panelForm.Controls.Add(labelForename);
            panelForm.Controls.Add(labelCreateSpecialItem);
            panelForm.Location = new Point(360, 170);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(560, 320);
            panelForm.TabIndex = 6;
            // 
            // numericUpDownWorkers
            // 
            numericUpDownWorkers.Font = new Font("Bahnschrift", 12F);
            numericUpDownWorkers.Location = new Point(221, 231);
            numericUpDownWorkers.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDownWorkers.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownWorkers.Name = "numericUpDownWorkers";
            numericUpDownWorkers.Size = new Size(86, 32);
            numericUpDownWorkers.TabIndex = 3;
            numericUpDownWorkers.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelWorkers
            // 
            labelWorkers.AutoSize = true;
            labelWorkers.Font = new Font("Bahnschrift", 14F);
            labelWorkers.ForeColor = Color.White;
            labelWorkers.Location = new Point(112, 231);
            labelWorkers.Name = "labelWorkers";
            labelWorkers.Size = new Size(103, 29);
            labelWorkers.TabIndex = 12;
            labelWorkers.Text = "Workers";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(188, 168);
            label1.Name = "label1";
            label1.Size = new Size(27, 29);
            label1.TabIndex = 11;
            label1.Text = "£";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Bahnschrift", 12F);
            textBoxPrice.Location = new Point(221, 168);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(227, 32);
            textBoxPrice.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Bahnschrift", 12F);
            textBoxName.Location = new Point(221, 105);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(227, 32);
            textBoxName.TabIndex = 1;
            // 
            // labelTelNo
            // 
            labelTelNo.AutoSize = true;
            labelTelNo.Font = new Font("Bahnschrift", 14F);
            labelTelNo.ForeColor = Color.White;
            labelTelNo.Location = new Point(122, 168);
            labelTelNo.Name = "labelTelNo";
            labelTelNo.Size = new Size(68, 29);
            labelTelNo.TabIndex = 8;
            labelTelNo.Text = "Price";
            // 
            // labelForename
            // 
            labelForename.AutoSize = true;
            labelForename.Font = new Font("Bahnschrift", 14F);
            labelForename.ForeColor = Color.White;
            labelForename.Location = new Point(138, 105);
            labelForename.Name = "labelForename";
            labelForename.Size = new Size(77, 29);
            labelForename.TabIndex = 4;
            labelForename.Text = "Name";
            // 
            // labelCreateSpecialItem
            // 
            labelCreateSpecialItem.AutoSize = true;
            labelCreateSpecialItem.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
            labelCreateSpecialItem.ForeColor = Color.White;
            labelCreateSpecialItem.Location = new Point(29, 34);
            labelCreateSpecialItem.Name = "labelCreateSpecialItem";
            labelCreateSpecialItem.Size = new Size(315, 41);
            labelCreateSpecialItem.TabIndex = 3;
            labelCreateSpecialItem.Text = "Create Special Item";
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
            customButtonSubmit.Location = new Point(802, 496);
            customButtonSubmit.Name = "customButtonSubmit";
            customButtonSubmit.Size = new Size(118, 56);
            customButtonSubmit.TabIndex = 4;
            customButtonSubmit.Text = "Submit";
            customButtonSubmit.UseVisualStyleBackColor = false;
            customButtonSubmit.Click += customButtonSubmit_Click;
            // 
            // SpecialItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 68, 102);
            ClientSize = new Size(1262, 744);
            Controls.Add(customButtonSubmit);
            Controls.Add(panelForm);
            Controls.Add(panelTopBar);
            Name = "SpecialItemForm";
            Text = "SpecialItemForm";
            panelTopBar.ResumeLayout(false);
            panelTopBar.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWorkers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopBar;
        private Button buttonBack;
        private Label labelSpecialItem;
        private Panel panelLogo;
        private Panel panelForm;
        private TextBox textBoxName;
        private Label labelTelNo;
        private Label labelForename;
        private Label labelCreateSpecialItem;
        private CustControlLib.CustomButton customButtonSubmit;
        private TextBox textBoxPrice;
        private Label label1;
        private NumericUpDown numericUpDownWorkers;
        private Label labelWorkers;
    }
}