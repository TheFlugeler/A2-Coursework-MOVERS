namespace Movers_Booking_System.Forms
{
    partial class DatabaseForm
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
            panel1 = new Panel();
            customButtonDelete = new CustControlLib.CustomButton();
            customButtonEdit = new CustControlLib.CustomButton();
            dataGridViewDatabase = new DataGridView();
            panelTopBar = new Panel();
            buttonBack = new Button();
            labelDatabase = new Label();
            panelLogo = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDatabase).BeginInit();
            panelTopBar.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 125, 187);
            panel1.Controls.Add(customButtonDelete);
            panel1.Controls.Add(customButtonEdit);
            panel1.Controls.Add(dataGridViewDatabase);
            panel1.Location = new Point(60, 140);
            panel1.Name = "panel1";
            panel1.Size = new Size(1140, 550);
            panel1.TabIndex = 5;
            // 
            // customButtonDelete
            // 
            customButtonDelete.BackColor = Color.White;
            customButtonDelete.BorderColor = Color.Black;
            customButtonDelete.BorderRadius = 30;
            customButtonDelete.BorderWidth = 0;
            customButtonDelete.FlatAppearance.BorderSize = 0;
            customButtonDelete.FlatStyle = FlatStyle.Flat;
            customButtonDelete.Font = new Font("Bahnschrift", 12F);
            customButtonDelete.ForeColor = Color.Black;
            customButtonDelete.Location = new Point(177, 488);
            customButtonDelete.Name = "customButtonDelete";
            customButtonDelete.Size = new Size(150, 50);
            customButtonDelete.TabIndex = 2;
            customButtonDelete.Text = "Delete Record";
            customButtonDelete.UseVisualStyleBackColor = false;
            customButtonDelete.Click += customButtonDelete_Click;
            // 
            // customButtonEdit
            // 
            customButtonEdit.BackColor = Color.White;
            customButtonEdit.BorderColor = Color.Black;
            customButtonEdit.BorderRadius = 30;
            customButtonEdit.BorderWidth = 0;
            customButtonEdit.FlatAppearance.BorderSize = 0;
            customButtonEdit.FlatStyle = FlatStyle.Flat;
            customButtonEdit.Font = new Font("Bahnschrift", 12F);
            customButtonEdit.ForeColor = Color.Black;
            customButtonEdit.Location = new Point(20, 488);
            customButtonEdit.Name = "customButtonEdit";
            customButtonEdit.Size = new Size(150, 50);
            customButtonEdit.TabIndex = 1;
            customButtonEdit.Text = "Edit Record";
            customButtonEdit.UseVisualStyleBackColor = false;
            customButtonEdit.Click += customButtonEdit_Click;
            // 
            // dataGridViewDatabase
            // 
            dataGridViewDatabase.AllowUserToAddRows = false;
            dataGridViewDatabase.AllowUserToDeleteRows = false;
            dataGridViewDatabase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDatabase.Location = new Point(20, 22);
            dataGridViewDatabase.Name = "dataGridViewDatabase";
            dataGridViewDatabase.ReadOnly = true;
            dataGridViewDatabase.RowHeadersWidth = 51;
            dataGridViewDatabase.Size = new Size(1100, 460);
            dataGridViewDatabase.TabIndex = 0;
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = Color.FromArgb(19, 21, 39);
            panelTopBar.Controls.Add(buttonBack);
            panelTopBar.Controls.Add(labelDatabase);
            panelTopBar.Controls.Add(panelLogo);
            panelTopBar.Dock = DockStyle.Top;
            panelTopBar.Location = new Point(0, 0);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(1262, 100);
            panelTopBar.TabIndex = 6;
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
            // labelDatabase
            // 
            labelDatabase.AutoSize = true;
            labelDatabase.Font = new Font("Bahnschrift", 24F, FontStyle.Bold);
            labelDatabase.ForeColor = Color.White;
            labelDatabase.Location = new Point(180, 25);
            labelDatabase.Name = "labelDatabase";
            labelDatabase.Size = new Size(281, 48);
            labelDatabase.TabIndex = 3;
            labelDatabase.Text = "Database View";
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
            // DatabaseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 68, 102);
            ClientSize = new Size(1262, 744);
            Controls.Add(panelTopBar);
            Controls.Add(panel1);
            Font = new Font("Bahnschrift", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "DatabaseForm";
            Text = "DatabaseForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDatabase).EndInit();
            panelTopBar.ResumeLayout(false);
            panelTopBar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panelTopBar;
        private Button buttonBack;
        private Label labelDatabase;
        private Panel panelLogo;
        private CustControlLib.CustomButton customButtonEdit;
        private DataGridView dataGridViewDatabase;
        private CustControlLib.CustomButton customButtonDelete;
    }
}