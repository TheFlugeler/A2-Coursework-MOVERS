namespace Movers_Booking_System.Forms
{
    partial class JobForm
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
            components = new System.ComponentModel.Container();
            panelFormArea = new Panel();
            customButtonSubmit = new CustControlLib.CustomButton();
            panelForm = new Panel();
            textBox1 = new TextBox();
            labelPaid = new Label();
            labelConfirmed = new Label();
            labelPrice = new Label();
            labelEstimate = new Label();
            checkBoxConfirmed = new CheckBox();
            textBoxPrice = new TextBox();
            comboBoxEstimate = new ComboBox();
            labelCreateJob = new Label();
            panelTopBar = new Panel();
            labelJob = new Label();
            buttonBack = new Button();
            panelLogo = new Panel();
            pictureBoxCustomer = new PictureBox();
            pictureBox1 = new PictureBox();
            toolTip = new ToolTip(components);
            panelFormArea.SuspendLayout();
            panelForm.SuspendLayout();
            panelTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            panelFormArea.TabIndex = 6;
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
            customButtonSubmit.Location = new Point(825, 446);
            customButtonSubmit.Name = "customButtonSubmit";
            customButtonSubmit.Size = new Size(111, 48);
            customButtonSubmit.TabIndex = 5;
            customButtonSubmit.Text = "Submit";
            customButtonSubmit.UseVisualStyleBackColor = false;
            customButtonSubmit.Click += customButtonSubmit_Click;
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.FromArgb(30, 125, 187);
            panelForm.Controls.Add(pictureBox1);
            panelForm.Controls.Add(pictureBoxCustomer);
            panelForm.Controls.Add(textBox1);
            panelForm.Controls.Add(labelPaid);
            panelForm.Controls.Add(labelConfirmed);
            panelForm.Controls.Add(labelPrice);
            panelForm.Controls.Add(labelEstimate);
            panelForm.Controls.Add(checkBoxConfirmed);
            panelForm.Controls.Add(textBoxPrice);
            panelForm.Controls.Add(comboBoxEstimate);
            panelForm.Controls.Add(labelCreateJob);
            panelForm.Location = new Point(360, 100);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(576, 340);
            panelForm.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Bahnschrift", 12F);
            textBox1.Location = new Point(232, 259);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 32);
            textBox1.TabIndex = 4;
            // 
            // labelPaid
            // 
            labelPaid.AutoSize = true;
            labelPaid.Font = new Font("Bahnschrift", 14F);
            labelPaid.ForeColor = Color.White;
            labelPaid.Location = new Point(41, 259);
            labelPaid.Name = "labelPaid";
            labelPaid.Size = new Size(181, 29);
            labelPaid.TabIndex = 11;
            labelPaid.Text = "Amount Paid   £";
            // 
            // labelConfirmed
            // 
            labelConfirmed.AutoSize = true;
            labelConfirmed.Font = new Font("Bahnschrift", 14F);
            labelConfirmed.ForeColor = Color.White;
            labelConfirmed.Location = new Point(97, 212);
            labelConfirmed.Name = "labelConfirmed";
            labelConfirmed.Size = new Size(125, 29);
            labelConfirmed.TabIndex = 10;
            labelConfirmed.Text = "Confirmed";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Bahnschrift", 14F);
            labelPrice.ForeColor = Color.White;
            labelPrice.Location = new Point(154, 166);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(68, 29);
            labelPrice.TabIndex = 9;
            labelPrice.Text = "Price";
            // 
            // labelEstimate
            // 
            labelEstimate.AutoSize = true;
            labelEstimate.Font = new Font("Bahnschrift", 14F);
            labelEstimate.ForeColor = Color.White;
            labelEstimate.Location = new Point(114, 108);
            labelEstimate.Name = "labelEstimate";
            labelEstimate.Size = new Size(108, 29);
            labelEstimate.TabIndex = 8;
            labelEstimate.Text = "Estimate";
            // 
            // checkBoxConfirmed
            // 
            checkBoxConfirmed.AutoSize = true;
            checkBoxConfirmed.Font = new Font("Bahnschrift", 12F);
            checkBoxConfirmed.Location = new Point(232, 221);
            checkBoxConfirmed.Name = "checkBoxConfirmed";
            checkBoxConfirmed.Size = new Size(18, 17);
            checkBoxConfirmed.TabIndex = 3;
            checkBoxConfirmed.UseVisualStyleBackColor = true;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Font = new Font("Bahnschrift", 12F);
            textBoxPrice.Location = new Point(232, 166);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(263, 32);
            textBoxPrice.TabIndex = 2;
            // 
            // comboBoxEstimate
            // 
            comboBoxEstimate.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEstimate.Font = new Font("Bahnschrift", 12F);
            comboBoxEstimate.FormattingEnabled = true;
            comboBoxEstimate.Location = new Point(232, 108);
            comboBoxEstimate.Name = "comboBoxEstimate";
            comboBoxEstimate.Size = new Size(263, 32);
            comboBoxEstimate.TabIndex = 1;
            comboBoxEstimate.SelectedIndexChanged += comboBoxEstimate_SelectedIndexChanged;
            // 
            // labelCreateJob
            // 
            labelCreateJob.AutoSize = true;
            labelCreateJob.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
            labelCreateJob.ForeColor = Color.White;
            labelCreateJob.Location = new Point(22, 30);
            labelCreateJob.Name = "labelCreateJob";
            labelCreateJob.Size = new Size(383, 41);
            labelCreateJob.TabIndex = 3;
            labelCreateJob.Text = "Convert Estimate to Job";
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = Color.FromArgb(19, 21, 39);
            panelTopBar.Controls.Add(labelJob);
            panelTopBar.Controls.Add(buttonBack);
            panelTopBar.Controls.Add(panelLogo);
            panelTopBar.Dock = DockStyle.Top;
            panelTopBar.Location = new Point(0, 0);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(1262, 100);
            panelTopBar.TabIndex = 5;
            // 
            // labelJob
            // 
            labelJob.AutoSize = true;
            labelJob.Font = new Font("Bahnschrift", 24F, FontStyle.Bold);
            labelJob.ForeColor = Color.White;
            labelJob.Location = new Point(180, 25);
            labelJob.Name = "labelJob";
            labelJob.Size = new Size(402, 48);
            labelJob.TabIndex = 2;
            labelJob.Text = "Job Conversion Form";
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
            buttonBack.TabIndex = 1;
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
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
            // pictureBoxCustomer
            // 
            pictureBoxCustomer.Image = Media.SystemImages.question;
            pictureBoxCustomer.Location = new Point(501, 112);
            pictureBoxCustomer.Name = "pictureBoxCustomer";
            pictureBoxCustomer.Size = new Size(25, 25);
            pictureBoxCustomer.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCustomer.TabIndex = 19;
            pictureBoxCustomer.TabStop = false;
            toolTip.SetToolTip(pictureBoxCustomer, "Select preexisting estimate");
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Media.SystemImages.question;
            pictureBox1.Location = new Point(501, 263);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            toolTip.SetToolTip(pictureBox1, "Amount paid must be at least the 50% deposit");
            // 
            // JobForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 68, 102);
            ClientSize = new Size(1262, 744);
            Controls.Add(panelFormArea);
            Controls.Add(panelTopBar);
            Name = "JobForm";
            Text = "JobForm";
            panelFormArea.ResumeLayout(false);
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            panelTopBar.ResumeLayout(false);
            panelTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFormArea;
        private Panel panelSpacer;
        private CustControlLib.CustomButton customButtonSubmit;
        private Panel panelForm;
        private CustControlLib.CustomButton customButtonAddSpecialItem;
        private ComboBox comboBoxSpecialItem;
        private Label labelItems;
        private RichTextBox richTextBoxSpecialItems;
        private Label labelCreateJob;
        private Panel panelTopBar;
        private Label labelJob;
        private Button buttonBack;
        private Panel panelLogo;
        private Label labelPaid;
        private Label labelConfirmed;
        private Label labelPrice;
        private Label labelEstimate;
        private CheckBox checkBoxConfirmed;
        private TextBox textBoxPrice;
        private ComboBox comboBoxEstimate;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private ToolTip toolTip;
        private PictureBox pictureBoxCustomer;
    }
}