namespace Movers_Booking_System.Forms
{
    partial class MessagesForm
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
            labelMessage = new Label();
            panelLogo = new Panel();
            panelMessages = new Panel();
            buttonJob = new Button();
            buttonEstimate = new Button();
            labelJobs = new Label();
            labelEstimates = new Label();
            labelActions = new Label();
            panelList = new Panel();
            dataGridView = new DataGridView();
            labelSelectedMessage = new Label();
            customButtonDelete = new CustControlLib.CustomButton();
            panelTopBar.SuspendLayout();
            panelMessages.SuspendLayout();
            panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = Color.FromArgb(19, 21, 39);
            panelTopBar.Controls.Add(buttonBack);
            panelTopBar.Controls.Add(labelMessage);
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
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Font = new Font("Bahnschrift", 24F, FontStyle.Bold);
            labelMessage.ForeColor = Color.White;
            labelMessage.Location = new Point(180, 25);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(199, 48);
            labelMessage.TabIndex = 3;
            labelMessage.Text = "Messages";
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
            // panelMessages
            // 
            panelMessages.BackColor = Color.FromArgb(30, 125, 187);
            panelMessages.Controls.Add(buttonJob);
            panelMessages.Controls.Add(buttonEstimate);
            panelMessages.Controls.Add(labelJobs);
            panelMessages.Controls.Add(labelEstimates);
            panelMessages.Controls.Add(labelActions);
            panelMessages.Location = new Point(370, 200);
            panelMessages.Name = "panelMessages";
            panelMessages.Size = new Size(540, 220);
            panelMessages.TabIndex = 6;
            // 
            // buttonJob
            // 
            buttonJob.BackgroundImage = Media.SystemImages.right_arrow;
            buttonJob.BackgroundImageLayout = ImageLayout.Stretch;
            buttonJob.FlatAppearance.BorderSize = 0;
            buttonJob.FlatStyle = FlatStyle.Flat;
            buttonJob.Location = new Point(479, 154);
            buttonJob.Name = "buttonJob";
            buttonJob.Size = new Size(30, 30);
            buttonJob.TabIndex = 8;
            buttonJob.UseVisualStyleBackColor = true;
            buttonJob.Click += buttonJob_Click;
            // 
            // buttonEstimate
            // 
            buttonEstimate.BackgroundImage = Media.SystemImages.right_arrow;
            buttonEstimate.BackgroundImageLayout = ImageLayout.Stretch;
            buttonEstimate.FlatAppearance.BorderSize = 0;
            buttonEstimate.FlatStyle = FlatStyle.Flat;
            buttonEstimate.Location = new Point(479, 100);
            buttonEstimate.Name = "buttonEstimate";
            buttonEstimate.Size = new Size(30, 30);
            buttonEstimate.TabIndex = 7;
            buttonEstimate.UseVisualStyleBackColor = true;
            buttonEstimate.Click += buttonEstimate_Click;
            // 
            // labelJobs
            // 
            labelJobs.AutoSize = true;
            labelJobs.Font = new Font("Bahnschrift", 14F);
            labelJobs.ForeColor = Color.White;
            labelJobs.Location = new Point(14, 155);
            labelJobs.Name = "labelJobs";
            labelJobs.Size = new Size(146, 29);
            labelJobs.TabIndex = 6;
            labelJobs.Text = "• Past Jobs:  ";
            // 
            // labelEstimates
            // 
            labelEstimates.AutoSize = true;
            labelEstimates.Font = new Font("Bahnschrift", 14F);
            labelEstimates.ForeColor = Color.White;
            labelEstimates.Location = new Point(14, 101);
            labelEstimates.Name = "labelEstimates";
            labelEstimates.Size = new Size(378, 29);
            labelEstimates.TabIndex = 5;
            labelEstimates.Text = "• Estimates past agreement date:  ";
            // 
            // labelActions
            // 
            labelActions.AutoSize = true;
            labelActions.Font = new Font("Bahnschrift", 24F, FontStyle.Bold);
            labelActions.ForeColor = Color.White;
            labelActions.Location = new Point(14, 28);
            labelActions.Name = "labelActions";
            labelActions.Size = new Size(334, 48);
            labelActions.TabIndex = 4;
            labelActions.Text = "Required Actions:";
            // 
            // panelList
            // 
            panelList.BackColor = Color.FromArgb(30, 125, 187);
            panelList.Controls.Add(dataGridView);
            panelList.Controls.Add(labelSelectedMessage);
            panelList.Location = new Point(320, 160);
            panelList.Name = "panelList";
            panelList.Size = new Size(640, 400);
            panelList.TabIndex = 7;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(19, 68);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(600, 314);
            dataGridView.TabIndex = 1;
            // 
            // labelSelectedMessage
            // 
            labelSelectedMessage.AutoSize = true;
            labelSelectedMessage.Font = new Font("Bahnschrift", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSelectedMessage.ForeColor = Color.White;
            labelSelectedMessage.Location = new Point(19, 24);
            labelSelectedMessage.Name = "labelSelectedMessage";
            labelSelectedMessage.Size = new Size(369, 34);
            labelSelectedMessage.TabIndex = 0;
            labelSelectedMessage.Text = "Delete all outdated records?";
            // 
            // customButtonDelete
            // 
            customButtonDelete.BackColor = Color.FromArgb(30, 125, 187);
            customButtonDelete.BorderColor = Color.Black;
            customButtonDelete.BorderRadius = 40;
            customButtonDelete.BorderWidth = 0;
            customButtonDelete.FlatAppearance.BorderSize = 0;
            customButtonDelete.FlatStyle = FlatStyle.Flat;
            customButtonDelete.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customButtonDelete.ForeColor = Color.White;
            customButtonDelete.Location = new Point(812, 566);
            customButtonDelete.Name = "customButtonDelete";
            customButtonDelete.Size = new Size(148, 50);
            customButtonDelete.TabIndex = 8;
            customButtonDelete.Text = "Delete All";
            customButtonDelete.UseVisualStyleBackColor = false;
            customButtonDelete.Click += customButtonDelete_Click;
            // 
            // MessagesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 68, 102);
            ClientSize = new Size(1262, 672);
            Controls.Add(customButtonDelete);
            Controls.Add(panelTopBar);
            Controls.Add(panelMessages);
            Controls.Add(panelList);
            Name = "MessagesForm";
            Text = "MessagesForm";
            panelTopBar.ResumeLayout(false);
            panelTopBar.PerformLayout();
            panelMessages.ResumeLayout(false);
            panelMessages.PerformLayout();
            panelList.ResumeLayout(false);
            panelList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopBar;
        private Button buttonBack;
        private Label labelMessage;
        private Panel panelLogo;
        private Panel panelMessages;
        private Label labelActions;
        private Button buttonJob;
        private Button buttonEstimate;
        private Label labelJobs;
        private Label labelEstimates;
        private Panel panelList;
        private Label labelSelectedMessage;
        private CustControlLib.CustomButton customButtonDelete;
        private DataGridView dataGridView;
    }
}