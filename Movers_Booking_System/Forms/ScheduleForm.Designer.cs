namespace Movers_Booking_System.Forms
{
    partial class ScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleForm));
            panelTopBar = new Panel();
            buttonBack = new Button();
            labelSchedule = new Label();
            panelLogo = new Panel();
            panelForm = new Panel();
            buttonRight = new Button();
            buttonLeft = new Button();
            textBox1 = new TextBox();
            labelDate = new Label();
            labelPrintSchedule = new Label();
            customButtonSubmit = new CustControlLib.CustomButton();
            printPreviewDialog = new PrintPreviewDialog();
            printDocument = new System.Drawing.Printing.PrintDocument();
            panelTopBar.SuspendLayout();
            panelForm.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = Color.FromArgb(19, 21, 39);
            panelTopBar.Controls.Add(buttonBack);
            panelTopBar.Controls.Add(labelSchedule);
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
            // labelSchedule
            // 
            labelSchedule.AutoSize = true;
            labelSchedule.Font = new Font("Bahnschrift", 24F, FontStyle.Bold);
            labelSchedule.ForeColor = Color.White;
            labelSchedule.Location = new Point(180, 25);
            labelSchedule.Name = "labelSchedule";
            labelSchedule.Size = new Size(301, 48);
            labelSchedule.TabIndex = 3;
            labelSchedule.Text = "Customer Form";
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
            panelForm.Controls.Add(buttonRight);
            panelForm.Controls.Add(buttonLeft);
            panelForm.Controls.Add(textBox1);
            panelForm.Controls.Add(labelDate);
            panelForm.Controls.Add(labelPrintSchedule);
            panelForm.Location = new Point(350, 240);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(569, 179);
            panelForm.TabIndex = 6;
            // 
            // buttonRight
            // 
            buttonRight.BackgroundImage = Media.SystemImages.right_arrow;
            buttonRight.BackgroundImageLayout = ImageLayout.Zoom;
            buttonRight.FlatAppearance.BorderSize = 0;
            buttonRight.FlatStyle = FlatStyle.Flat;
            buttonRight.Font = new Font("Bahnschrift", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRight.ForeColor = Color.White;
            buttonRight.Location = new Point(508, 90);
            buttonRight.Name = "buttonRight";
            buttonRight.Size = new Size(30, 30);
            buttonRight.TabIndex = 2;
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
            buttonLeft.Location = new Point(222, 91);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(30, 30);
            buttonLeft.TabIndex = 1;
            buttonLeft.UseVisualStyleBackColor = true;
            buttonLeft.Click += buttonLeft_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(258, 91);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(244, 32);
            textBox1.TabIndex = 6;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Bahnschrift", 14F);
            labelDate.ForeColor = Color.White;
            labelDate.Location = new Point(24, 91);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(182, 29);
            labelDate.TabIndex = 5;
            labelDate.Text = "Week Beginning";
            // 
            // labelPrintSchedule
            // 
            labelPrintSchedule.AutoSize = true;
            labelPrintSchedule.Font = new Font("Bahnschrift", 20F, FontStyle.Bold);
            labelPrintSchedule.ForeColor = Color.White;
            labelPrintSchedule.Location = new Point(20, 20);
            labelPrintSchedule.Name = "labelPrintSchedule";
            labelPrintSchedule.Size = new Size(241, 41);
            labelPrintSchedule.TabIndex = 3;
            labelPrintSchedule.Text = "Print Schedule";
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
            customButtonSubmit.Location = new Point(800, 425);
            customButtonSubmit.Name = "customButtonSubmit";
            customButtonSubmit.Size = new Size(119, 43);
            customButtonSubmit.TabIndex = 3;
            customButtonSubmit.Text = "Print";
            customButtonSubmit.UseVisualStyleBackColor = false;
            customButtonSubmit.Click += customButtonSubmit_Click;
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
            // printDocument
            // 
            printDocument.PrintPage += printDocument_PrintPage;
            // 
            // ScheduleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 68, 102);
            ClientSize = new Size(1262, 744);
            Controls.Add(customButtonSubmit);
            Controls.Add(panelForm);
            Controls.Add(panelTopBar);
            Name = "ScheduleForm";
            Text = "ScheduleForm";
            panelTopBar.ResumeLayout(false);
            panelTopBar.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopBar;
        private Button buttonBack;
        private Label labelSchedule;
        private Panel panelLogo;
        private Panel panelForm;
        private Label labelPrintSchedule;
        private Label labelDate;
        private CustControlLib.CustomButton customButtonSubmit;
        private PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private TextBox textBox1;
        private Button buttonLeft;
        private Button buttonRight;
    }
}