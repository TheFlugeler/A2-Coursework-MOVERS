namespace Movers_Booking_System.Forms
{
    partial class PrintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
            printDocument = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog = new PrintPreviewDialog();
            panelTopBar = new Panel();
            buttonBack = new Button();
            labelPrint = new Label();
            panelLogo = new Panel();
            panelForm = new Panel();
            labelPrice = new Label();
            labelRecord = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            labelSelectRecord = new Label();
            customButtonPrint = new CustControlLib.CustomButton();
            panelTopBar.SuspendLayout();
            panelForm.SuspendLayout();
            SuspendLayout();
            // 
            // printDocument
            // 
            printDocument.PrintPage += printDocument_PrintPage;
            // 
            // printPreviewDialog
            // 
            printPreviewDialog.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Enabled = true;
            printPreviewDialog.Icon = (Icon)resources.GetObject("printPreviewDialog.Icon");
            printPreviewDialog.Name = "printPreviewDialog";
            printPreviewDialog.Visible = false;
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = Color.FromArgb(19, 21, 39);
            panelTopBar.Controls.Add(buttonBack);
            panelTopBar.Controls.Add(labelPrint);
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
            // labelPrint
            // 
            labelPrint.AutoSize = true;
            labelPrint.Font = new Font("Bahnschrift", 24F, FontStyle.Bold);
            labelPrint.ForeColor = Color.White;
            labelPrint.Location = new Point(180, 25);
            labelPrint.Name = "labelPrint";
            labelPrint.Size = new Size(106, 48);
            labelPrint.TabIndex = 3;
            labelPrint.Text = "Print";
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
            panelForm.Controls.Add(labelPrice);
            panelForm.Controls.Add(labelRecord);
            panelForm.Controls.Add(textBox1);
            panelForm.Controls.Add(comboBox1);
            panelForm.Controls.Add(labelSelectRecord);
            panelForm.Location = new Point(351, 192);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(560, 293);
            panelForm.TabIndex = 6;
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Bahnschrift", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrice.ForeColor = Color.White;
            labelPrice.Location = new Point(106, 186);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(90, 28);
            labelPrice.TabIndex = 7;
            labelPrice.Text = "Price  £";
            // 
            // labelRecord
            // 
            labelRecord.AutoSize = true;
            labelRecord.Font = new Font("Bahnschrift", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelRecord.ForeColor = Color.White;
            labelRecord.Location = new Point(111, 109);
            labelRecord.Name = "labelRecord";
            labelRecord.Size = new Size(85, 28);
            labelRecord.TabIndex = 6;
            labelRecord.Text = "Record";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(210, 186);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(279, 32);
            textBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(210, 109);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(279, 32);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // labelSelectRecord
            // 
            labelSelectRecord.AutoSize = true;
            labelSelectRecord.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
            labelSelectRecord.ForeColor = Color.White;
            labelSelectRecord.Location = new Point(32, 32);
            labelSelectRecord.Name = "labelSelectRecord";
            labelSelectRecord.Size = new Size(113, 41);
            labelSelectRecord.TabIndex = 3;
            labelSelectRecord.Text = "Select";
            // 
            // customButtonPrint
            // 
            customButtonPrint.BackColor = Color.FromArgb(30, 125, 187);
            customButtonPrint.BorderColor = Color.Black;
            customButtonPrint.BorderRadius = 40;
            customButtonPrint.BorderWidth = 0;
            customButtonPrint.FlatAppearance.BorderSize = 0;
            customButtonPrint.FlatStyle = FlatStyle.Flat;
            customButtonPrint.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButtonPrint.ForeColor = Color.White;
            customButtonPrint.Location = new Point(797, 502);
            customButtonPrint.Name = "customButtonPrint";
            customButtonPrint.Size = new Size(114, 50);
            customButtonPrint.TabIndex = 2;
            customButtonPrint.Text = "Print";
            customButtonPrint.UseVisualStyleBackColor = false;
            customButtonPrint.Click += customButtonPrint_Click;
            // 
            // PrintForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 68, 102);
            ClientSize = new Size(1262, 744);
            Controls.Add(customButtonPrint);
            Controls.Add(panelForm);
            Controls.Add(panelTopBar);
            Name = "PrintForm";
            Text = "PrintForm";
            panelTopBar.ResumeLayout(false);
            panelTopBar.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        private Panel panelTopBar;
        private Button buttonBack;
        private Label labelPrint;
        private Panel panelLogo;
        private Panel panelForm;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private TextBox textBoxForename;
        private TextBox textBoxTelNo;
        private Label labelTelNo;
        private TextBox textBoxSurname;
        private Label labelSurname;
        private Label labelForename;
        private Label labelSelectRecord;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private CustControlLib.CustomButton customButtonPrint;
        private Label labelPrice;
        private Label labelRecord;
    }
}