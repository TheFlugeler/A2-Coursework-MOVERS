namespace Movers_Booking_System.Forms
{
    partial class MainForm
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
            panelTopBar = new Panel();
            panelLogo = new Panel();
            panelFormDropdown = new Panel();
            buttonSpecialItemForm = new Button();
            buttonCustomerForm = new Button();
            buttonInspectionForm = new Button();
            buttonJobForm = new Button();
            buttonEstimateForm = new Button();
            panelFormDropdownButton = new Panel();
            labelForm = new Label();
            pictureBoxForm = new PictureBox();
            timerFormDropdown = new System.Windows.Forms.Timer(components);
            panelDatabaseDropdown = new Panel();
            buttonAccessItem = new Button();
            buttonAccessCustomer = new Button();
            buttonAcessInspection = new Button();
            buttonAccessEstimate = new Button();
            panelDatabaseButton = new Panel();
            labelDatabase = new Label();
            pictureBoxDatabase = new PictureBox();
            timerDatabaseDropdown = new System.Windows.Forms.Timer(components);
            panelProfileButton = new Panel();
            pictureBoxProfile = new PictureBox();
            panelProfileDropdown = new Panel();
            buttonLogout = new Button();
            buttonMessages = new Button();
            buttonProfile = new Button();
            timerProfileDropdown = new System.Windows.Forms.Timer(components);
            panelPrintDropdown = new Panel();
            buttonPrintSchedule = new Button();
            buttonPrintInspection = new Button();
            buttonPrintJob = new Button();
            panelPrintButton = new Panel();
            labelPrint = new Label();
            pictureBoxPrint = new PictureBox();
            timerPrintDropdown = new System.Windows.Forms.Timer(components);
            panelTopBar.SuspendLayout();
            panelFormDropdown.SuspendLayout();
            panelFormDropdownButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForm).BeginInit();
            panelDatabaseDropdown.SuspendLayout();
            panelDatabaseButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDatabase).BeginInit();
            panelProfileButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).BeginInit();
            panelProfileDropdown.SuspendLayout();
            panelPrintDropdown.SuspendLayout();
            panelPrintButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrint).BeginInit();
            SuspendLayout();
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = Color.FromArgb(19, 21, 39);
            panelTopBar.Controls.Add(panelLogo);
            panelTopBar.Dock = DockStyle.Top;
            panelTopBar.Location = new Point(0, 0);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(1262, 100);
            panelTopBar.TabIndex = 2;
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
            // panelFormDropdown
            // 
            panelFormDropdown.BackColor = Color.FromArgb(12, 41, 74);
            panelFormDropdown.Controls.Add(buttonSpecialItemForm);
            panelFormDropdown.Controls.Add(buttonCustomerForm);
            panelFormDropdown.Controls.Add(buttonInspectionForm);
            panelFormDropdown.Controls.Add(buttonJobForm);
            panelFormDropdown.Controls.Add(buttonEstimateForm);
            panelFormDropdown.Controls.Add(panelFormDropdownButton);
            panelFormDropdown.Location = new Point(180, 0);
            panelFormDropdown.MaximumSize = new Size(160, 400);
            panelFormDropdown.MinimumSize = new Size(160, 100);
            panelFormDropdown.Name = "panelFormDropdown";
            panelFormDropdown.Size = new Size(160, 400);
            panelFormDropdown.TabIndex = 1;
            // 
            // buttonSpecialItemForm
            // 
            buttonSpecialItemForm.Dock = DockStyle.Top;
            buttonSpecialItemForm.FlatAppearance.BorderSize = 0;
            buttonSpecialItemForm.FlatStyle = FlatStyle.Flat;
            buttonSpecialItemForm.Font = new Font("Bahnschrift", 12F);
            buttonSpecialItemForm.ForeColor = Color.White;
            buttonSpecialItemForm.Location = new Point(0, 340);
            buttonSpecialItemForm.Name = "buttonSpecialItemForm";
            buttonSpecialItemForm.Size = new Size(160, 60);
            buttonSpecialItemForm.TabIndex = 5;
            buttonSpecialItemForm.Text = "Special Item";
            buttonSpecialItemForm.UseVisualStyleBackColor = true;
            buttonSpecialItemForm.Click += buttonSpecialItemForm_Click;
            // 
            // buttonCustomerForm
            // 
            buttonCustomerForm.Dock = DockStyle.Top;
            buttonCustomerForm.FlatAppearance.BorderSize = 0;
            buttonCustomerForm.FlatStyle = FlatStyle.Flat;
            buttonCustomerForm.Font = new Font("Bahnschrift", 12F);
            buttonCustomerForm.ForeColor = Color.White;
            buttonCustomerForm.Location = new Point(0, 280);
            buttonCustomerForm.Name = "buttonCustomerForm";
            buttonCustomerForm.Size = new Size(160, 60);
            buttonCustomerForm.TabIndex = 4;
            buttonCustomerForm.Text = "Customer";
            buttonCustomerForm.UseVisualStyleBackColor = true;
            buttonCustomerForm.Click += buttonCustomerForm_Click;
            // 
            // buttonInspectionForm
            // 
            buttonInspectionForm.Dock = DockStyle.Top;
            buttonInspectionForm.FlatAppearance.BorderSize = 0;
            buttonInspectionForm.FlatStyle = FlatStyle.Flat;
            buttonInspectionForm.Font = new Font("Bahnschrift", 12F);
            buttonInspectionForm.ForeColor = Color.White;
            buttonInspectionForm.Location = new Point(0, 220);
            buttonInspectionForm.Name = "buttonInspectionForm";
            buttonInspectionForm.Size = new Size(160, 60);
            buttonInspectionForm.TabIndex = 3;
            buttonInspectionForm.Text = "Inspection";
            buttonInspectionForm.UseVisualStyleBackColor = true;
            buttonInspectionForm.Click += buttonInspectionForm_Click;
            // 
            // buttonJobForm
            // 
            buttonJobForm.Dock = DockStyle.Top;
            buttonJobForm.FlatAppearance.BorderSize = 0;
            buttonJobForm.FlatStyle = FlatStyle.Flat;
            buttonJobForm.Font = new Font("Bahnschrift", 12F);
            buttonJobForm.ForeColor = Color.White;
            buttonJobForm.Location = new Point(0, 160);
            buttonJobForm.Name = "buttonJobForm";
            buttonJobForm.Size = new Size(160, 60);
            buttonJobForm.TabIndex = 2;
            buttonJobForm.Text = "Jobs";
            buttonJobForm.UseVisualStyleBackColor = true;
            buttonJobForm.Click += buttonJobForm_Click;
            // 
            // buttonEstimateForm
            // 
            buttonEstimateForm.Dock = DockStyle.Top;
            buttonEstimateForm.FlatAppearance.BorderSize = 0;
            buttonEstimateForm.FlatStyle = FlatStyle.Flat;
            buttonEstimateForm.Font = new Font("Bahnschrift", 12F);
            buttonEstimateForm.ForeColor = Color.White;
            buttonEstimateForm.Location = new Point(0, 100);
            buttonEstimateForm.Name = "buttonEstimateForm";
            buttonEstimateForm.Size = new Size(160, 60);
            buttonEstimateForm.TabIndex = 1;
            buttonEstimateForm.Text = "Estimates";
            buttonEstimateForm.UseVisualStyleBackColor = true;
            buttonEstimateForm.Click += buttonEstimateForm_Click;
            // 
            // panelFormDropdownButton
            // 
            panelFormDropdownButton.BackColor = Color.FromArgb(19, 21, 39);
            panelFormDropdownButton.Controls.Add(labelForm);
            panelFormDropdownButton.Controls.Add(pictureBoxForm);
            panelFormDropdownButton.Dock = DockStyle.Top;
            panelFormDropdownButton.Location = new Point(0, 0);
            panelFormDropdownButton.Name = "panelFormDropdownButton";
            panelFormDropdownButton.Size = new Size(160, 100);
            panelFormDropdownButton.TabIndex = 0;
            panelFormDropdownButton.Click += panelFormDropdownButton_Click;
            // 
            // labelForm
            // 
            labelForm.AutoSize = true;
            labelForm.Font = new Font("Bahnschrift", 16F);
            labelForm.ForeColor = Color.White;
            labelForm.Location = new Point(10, 32);
            labelForm.Name = "labelForm";
            labelForm.Size = new Size(94, 33);
            labelForm.TabIndex = 1;
            labelForm.Text = "Forms";
            labelForm.Click += panelFormDropdownButton_Click;
            // 
            // pictureBoxForm
            // 
            pictureBoxForm.BackgroundImage = Media.SystemImages.down;
            pictureBoxForm.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxForm.Location = new Point(110, 32);
            pictureBoxForm.Name = "pictureBoxForm";
            pictureBoxForm.Size = new Size(40, 40);
            pictureBoxForm.TabIndex = 0;
            pictureBoxForm.TabStop = false;
            pictureBoxForm.Click += panelFormDropdownButton_Click;
            // 
            // timerFormDropdown
            // 
            timerFormDropdown.Interval = 10;
            timerFormDropdown.Tick += timerFormDropdown_Tick;
            // 
            // panelDatabaseDropdown
            // 
            panelDatabaseDropdown.BackColor = Color.FromArgb(12, 41, 74);
            panelDatabaseDropdown.Controls.Add(buttonAccessItem);
            panelDatabaseDropdown.Controls.Add(buttonAccessCustomer);
            panelDatabaseDropdown.Controls.Add(buttonAcessInspection);
            panelDatabaseDropdown.Controls.Add(buttonAccessEstimate);
            panelDatabaseDropdown.Controls.Add(panelDatabaseButton);
            panelDatabaseDropdown.Location = new Point(340, 0);
            panelDatabaseDropdown.MaximumSize = new Size(180, 340);
            panelDatabaseDropdown.MinimumSize = new Size(180, 100);
            panelDatabaseDropdown.Name = "panelDatabaseDropdown";
            panelDatabaseDropdown.Size = new Size(180, 340);
            panelDatabaseDropdown.TabIndex = 4;
            // 
            // buttonAccessItem
            // 
            buttonAccessItem.Dock = DockStyle.Top;
            buttonAccessItem.FlatAppearance.BorderSize = 0;
            buttonAccessItem.FlatStyle = FlatStyle.Flat;
            buttonAccessItem.Font = new Font("Bahnschrift", 12F);
            buttonAccessItem.ForeColor = Color.White;
            buttonAccessItem.Location = new Point(0, 280);
            buttonAccessItem.Name = "buttonAccessItem";
            buttonAccessItem.Size = new Size(180, 60);
            buttonAccessItem.TabIndex = 5;
            buttonAccessItem.Text = "Special Items";
            buttonAccessItem.UseVisualStyleBackColor = true;
            buttonAccessItem.Click += buttonAccessItem_Click;
            // 
            // buttonAccessCustomer
            // 
            buttonAccessCustomer.Dock = DockStyle.Top;
            buttonAccessCustomer.FlatAppearance.BorderSize = 0;
            buttonAccessCustomer.FlatStyle = FlatStyle.Flat;
            buttonAccessCustomer.Font = new Font("Bahnschrift", 12F);
            buttonAccessCustomer.ForeColor = Color.White;
            buttonAccessCustomer.Location = new Point(0, 220);
            buttonAccessCustomer.Name = "buttonAccessCustomer";
            buttonAccessCustomer.Size = new Size(180, 60);
            buttonAccessCustomer.TabIndex = 4;
            buttonAccessCustomer.Text = "Customers";
            buttonAccessCustomer.UseVisualStyleBackColor = true;
            buttonAccessCustomer.Click += buttonAccessCustomer_Click;
            // 
            // buttonAcessInspection
            // 
            buttonAcessInspection.Dock = DockStyle.Top;
            buttonAcessInspection.FlatAppearance.BorderSize = 0;
            buttonAcessInspection.FlatStyle = FlatStyle.Flat;
            buttonAcessInspection.Font = new Font("Bahnschrift", 12F);
            buttonAcessInspection.ForeColor = Color.White;
            buttonAcessInspection.Location = new Point(0, 160);
            buttonAcessInspection.Name = "buttonAcessInspection";
            buttonAcessInspection.Size = new Size(180, 60);
            buttonAcessInspection.TabIndex = 3;
            buttonAcessInspection.Text = "Inspections";
            buttonAcessInspection.UseVisualStyleBackColor = true;
            buttonAcessInspection.Click += buttonAcessInspection_Click;
            // 
            // buttonAccessEstimate
            // 
            buttonAccessEstimate.Dock = DockStyle.Top;
            buttonAccessEstimate.FlatAppearance.BorderSize = 0;
            buttonAccessEstimate.FlatStyle = FlatStyle.Flat;
            buttonAccessEstimate.Font = new Font("Bahnschrift", 12F);
            buttonAccessEstimate.ForeColor = Color.White;
            buttonAccessEstimate.Location = new Point(0, 100);
            buttonAccessEstimate.Name = "buttonAccessEstimate";
            buttonAccessEstimate.Size = new Size(180, 60);
            buttonAccessEstimate.TabIndex = 1;
            buttonAccessEstimate.Text = "Jobs";
            buttonAccessEstimate.UseVisualStyleBackColor = true;
            buttonAccessEstimate.Click += buttonAccessEstimate_Click;
            // 
            // panelDatabaseButton
            // 
            panelDatabaseButton.BackColor = Color.FromArgb(19, 21, 39);
            panelDatabaseButton.Controls.Add(labelDatabase);
            panelDatabaseButton.Controls.Add(pictureBoxDatabase);
            panelDatabaseButton.Dock = DockStyle.Top;
            panelDatabaseButton.Location = new Point(0, 0);
            panelDatabaseButton.Name = "panelDatabaseButton";
            panelDatabaseButton.Size = new Size(180, 100);
            panelDatabaseButton.TabIndex = 0;
            panelDatabaseButton.Click += panelDatabaseButton_Click;
            // 
            // labelDatabase
            // 
            labelDatabase.AutoSize = true;
            labelDatabase.Font = new Font("Bahnschrift", 16F);
            labelDatabase.ForeColor = Color.White;
            labelDatabase.Location = new Point(9, 32);
            labelDatabase.Name = "labelDatabase";
            labelDatabase.Size = new Size(127, 33);
            labelDatabase.TabIndex = 1;
            labelDatabase.Text = "Database";
            labelDatabase.Click += panelDatabaseButton_Click;
            // 
            // pictureBoxDatabase
            // 
            pictureBoxDatabase.BackgroundImage = Media.SystemImages.down;
            pictureBoxDatabase.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxDatabase.Location = new Point(132, 32);
            pictureBoxDatabase.Name = "pictureBoxDatabase";
            pictureBoxDatabase.Size = new Size(40, 40);
            pictureBoxDatabase.TabIndex = 0;
            pictureBoxDatabase.TabStop = false;
            pictureBoxDatabase.Click += panelDatabaseButton_Click;
            // 
            // timerDatabaseDropdown
            // 
            timerDatabaseDropdown.Interval = 10;
            timerDatabaseDropdown.Tick += timerDatabaseDropdown_Tick;
            // 
            // panelProfileButton
            // 
            panelProfileButton.BackColor = Color.FromArgb(19, 21, 39);
            panelProfileButton.Controls.Add(pictureBoxProfile);
            panelProfileButton.Dock = DockStyle.Top;
            panelProfileButton.Location = new Point(0, 0);
            panelProfileButton.Name = "panelProfileButton";
            panelProfileButton.Size = new Size(100, 100);
            panelProfileButton.TabIndex = 1;
            panelProfileButton.Click += panelProfileButton_Click;
            // 
            // pictureBoxProfile
            // 
            pictureBoxProfile.Location = new Point(13, 13);
            pictureBoxProfile.Name = "pictureBoxProfile";
            pictureBoxProfile.Size = new Size(75, 75);
            pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProfile.TabIndex = 1;
            pictureBoxProfile.TabStop = false;
            pictureBoxProfile.Click += panelProfileButton_Click;
            // 
            // panelProfileDropdown
            // 
            panelProfileDropdown.BackColor = Color.FromArgb(12, 41, 74);
            panelProfileDropdown.Controls.Add(buttonLogout);
            panelProfileDropdown.Controls.Add(buttonMessages);
            panelProfileDropdown.Controls.Add(buttonProfile);
            panelProfileDropdown.Controls.Add(panelProfileButton);
            panelProfileDropdown.Location = new Point(1162, 0);
            panelProfileDropdown.MaximumSize = new Size(100, 280);
            panelProfileDropdown.MinimumSize = new Size(100, 100);
            panelProfileDropdown.Name = "panelProfileDropdown";
            panelProfileDropdown.Size = new Size(100, 280);
            panelProfileDropdown.TabIndex = 5;
            // 
            // buttonLogout
            // 
            buttonLogout.BackgroundImage = Media.SystemImages.logout;
            buttonLogout.BackgroundImageLayout = ImageLayout.Zoom;
            buttonLogout.Dock = DockStyle.Top;
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogout.ForeColor = Color.White;
            buttonLogout.Location = new Point(0, 220);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(100, 60);
            buttonLogout.TabIndex = 4;
            buttonLogout.UseVisualStyleBackColor = true;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // buttonMessages
            // 
            buttonMessages.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMessages.Dock = DockStyle.Top;
            buttonMessages.FlatAppearance.BorderSize = 0;
            buttonMessages.FlatStyle = FlatStyle.Flat;
            buttonMessages.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonMessages.ForeColor = Color.White;
            buttonMessages.Location = new Point(0, 160);
            buttonMessages.Name = "buttonMessages";
            buttonMessages.Size = new Size(100, 60);
            buttonMessages.TabIndex = 3;
            buttonMessages.UseVisualStyleBackColor = true;
            buttonMessages.Click += buttonMessages_Click;
            // 
            // buttonProfile
            // 
            buttonProfile.BackgroundImage = Media.SystemImages.profile_user;
            buttonProfile.BackgroundImageLayout = ImageLayout.Zoom;
            buttonProfile.Dock = DockStyle.Top;
            buttonProfile.FlatAppearance.BorderSize = 0;
            buttonProfile.FlatStyle = FlatStyle.Flat;
            buttonProfile.Font = new Font("Bahnschrift", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonProfile.ForeColor = Color.White;
            buttonProfile.ImageAlign = ContentAlignment.MiddleRight;
            buttonProfile.Location = new Point(0, 100);
            buttonProfile.Name = "buttonProfile";
            buttonProfile.Size = new Size(100, 60);
            buttonProfile.TabIndex = 2;
            buttonProfile.UseVisualStyleBackColor = true;
            buttonProfile.Click += buttonProfile_Click;
            // 
            // timerProfileDropdown
            // 
            timerProfileDropdown.Interval = 10;
            timerProfileDropdown.Tick += timerProfileDropdown_Tick;
            // 
            // panelPrintDropdown
            // 
            panelPrintDropdown.BackColor = Color.FromArgb(12, 41, 74);
            panelPrintDropdown.Controls.Add(buttonPrintSchedule);
            panelPrintDropdown.Controls.Add(buttonPrintInspection);
            panelPrintDropdown.Controls.Add(buttonPrintJob);
            panelPrintDropdown.Controls.Add(panelPrintButton);
            panelPrintDropdown.Location = new Point(520, 0);
            panelPrintDropdown.MaximumSize = new Size(160, 280);
            panelPrintDropdown.MinimumSize = new Size(160, 100);
            panelPrintDropdown.Name = "panelPrintDropdown";
            panelPrintDropdown.Size = new Size(160, 280);
            panelPrintDropdown.TabIndex = 6;
            // 
            // buttonPrintSchedule
            // 
            buttonPrintSchedule.Dock = DockStyle.Top;
            buttonPrintSchedule.FlatAppearance.BorderSize = 0;
            buttonPrintSchedule.FlatStyle = FlatStyle.Flat;
            buttonPrintSchedule.Font = new Font("Bahnschrift", 12F);
            buttonPrintSchedule.ForeColor = Color.White;
            buttonPrintSchedule.Location = new Point(0, 220);
            buttonPrintSchedule.Name = "buttonPrintSchedule";
            buttonPrintSchedule.Size = new Size(160, 60);
            buttonPrintSchedule.TabIndex = 4;
            buttonPrintSchedule.Text = "Schedule";
            buttonPrintSchedule.UseVisualStyleBackColor = true;
            buttonPrintSchedule.Click += buttonPrintSchedule_Click;
            // 
            // buttonPrintInspection
            // 
            buttonPrintInspection.Dock = DockStyle.Top;
            buttonPrintInspection.FlatAppearance.BorderSize = 0;
            buttonPrintInspection.FlatStyle = FlatStyle.Flat;
            buttonPrintInspection.Font = new Font("Bahnschrift", 12F);
            buttonPrintInspection.ForeColor = Color.White;
            buttonPrintInspection.Location = new Point(0, 160);
            buttonPrintInspection.Name = "buttonPrintInspection";
            buttonPrintInspection.Size = new Size(160, 60);
            buttonPrintInspection.TabIndex = 3;
            buttonPrintInspection.Text = "Inspection";
            buttonPrintInspection.UseVisualStyleBackColor = true;
            buttonPrintInspection.Click += buttonPrintInspection_Click;
            // 
            // buttonPrintJob
            // 
            buttonPrintJob.Dock = DockStyle.Top;
            buttonPrintJob.FlatAppearance.BorderSize = 0;
            buttonPrintJob.FlatStyle = FlatStyle.Flat;
            buttonPrintJob.Font = new Font("Bahnschrift", 12F);
            buttonPrintJob.ForeColor = Color.White;
            buttonPrintJob.Location = new Point(0, 100);
            buttonPrintJob.Name = "buttonPrintJob";
            buttonPrintJob.Size = new Size(160, 60);
            buttonPrintJob.TabIndex = 2;
            buttonPrintJob.Text = "Job";
            buttonPrintJob.UseVisualStyleBackColor = true;
            buttonPrintJob.Click += buttonPrintJob_Click;
            // 
            // panelPrintButton
            // 
            panelPrintButton.BackColor = Color.FromArgb(19, 21, 39);
            panelPrintButton.Controls.Add(labelPrint);
            panelPrintButton.Controls.Add(pictureBoxPrint);
            panelPrintButton.Dock = DockStyle.Top;
            panelPrintButton.Location = new Point(0, 0);
            panelPrintButton.Name = "panelPrintButton";
            panelPrintButton.Size = new Size(160, 100);
            panelPrintButton.TabIndex = 0;
            panelPrintButton.Click += panelPrintButton_Click;
            // 
            // labelPrint
            // 
            labelPrint.AutoSize = true;
            labelPrint.Font = new Font("Bahnschrift", 16F);
            labelPrint.ForeColor = Color.White;
            labelPrint.Location = new Point(18, 32);
            labelPrint.Name = "labelPrint";
            labelPrint.Size = new Size(74, 33);
            labelPrint.TabIndex = 1;
            labelPrint.Text = "Print";
            labelPrint.Click += panelPrintButton_Click;
            // 
            // pictureBoxPrint
            // 
            pictureBoxPrint.BackgroundImage = Media.SystemImages.down;
            pictureBoxPrint.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxPrint.Location = new Point(98, 32);
            pictureBoxPrint.Name = "pictureBoxPrint";
            pictureBoxPrint.Size = new Size(40, 40);
            pictureBoxPrint.TabIndex = 0;
            pictureBoxPrint.TabStop = false;
            pictureBoxPrint.Click += panelPrintButton_Click;
            // 
            // timerPrintDropdown
            // 
            timerPrintDropdown.Interval = 10;
            timerPrintDropdown.Tick += timerPrintDropdown_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 68, 102);
            ClientSize = new Size(1262, 744);
            Controls.Add(panelPrintDropdown);
            Controls.Add(panelDatabaseDropdown);
            Controls.Add(panelProfileDropdown);
            Controls.Add(panelFormDropdown);
            Controls.Add(panelTopBar);
            Name = "MainForm";
            Text = "MainForm";
            panelTopBar.ResumeLayout(false);
            panelFormDropdown.ResumeLayout(false);
            panelFormDropdownButton.ResumeLayout(false);
            panelFormDropdownButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForm).EndInit();
            panelDatabaseDropdown.ResumeLayout(false);
            panelDatabaseButton.ResumeLayout(false);
            panelDatabaseButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDatabase).EndInit();
            panelProfileButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfile).EndInit();
            panelProfileDropdown.ResumeLayout(false);
            panelPrintDropdown.ResumeLayout(false);
            panelPrintButton.ResumeLayout(false);
            panelPrintButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPrint).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopBar;
        private Panel panelLogo;
        private Panel panelFormDropdown;
        private Panel panelFormDropdownButton;
        private Label labelForm;
        private PictureBox pictureBoxForm;
        private Button buttonEstimateForm;
        private Button buttonInspectionForm;
        private Button buttonJobForm;
        private System.Windows.Forms.Timer timerFormDropdown;
        private Panel panelDatabaseDropdown;
        private Button buttonAcessInspection;
        private Button buttonAccessEstimate;
        private Panel panelDatabaseButton;
        private Label labelDatabase;
        private PictureBox pictureBoxDatabase;
        private Button buttonAccessCustomer;
        private System.Windows.Forms.Timer timerDatabaseDropdown;
        private Panel panelProfileButton;
        private PictureBox pictureBoxProfile;
        private Panel panelProfileDropdown;
        private System.Windows.Forms.Timer timerProfileDropdown;
        private Button buttonProfile;
        private Button buttonLogout;
        private Button buttonMessages;
        private Button buttonCustomerForm;
        private Button buttonSpecialItemForm;
        private Button buttonAccessItem;
        private Panel panelPrintDropdown;
        private Button buttonPrintInspection;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panelPrintButton;
        private Label labelPrint;
        private PictureBox pictureBoxPrint;
        private Button buttonPrintJob;
        private System.Windows.Forms.Timer timerPrintDropdown;
        private Button buttonPrintSchedule;
    }
}