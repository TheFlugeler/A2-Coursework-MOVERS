namespace Movers_Booking_System.Forms
{
    partial class LoadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            pictureBoxAnimation = new PictureBox();
            customPanelBar = new CustControlLib.CustomPanel();
            customPanelBackground = new CustControlLib.CustomPanel();
            timerBar = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnimation).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAnimation
            // 
            pictureBoxAnimation.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxAnimation.Image = Media.SystemImages.MOVERS_Animation___Dark;
            pictureBoxAnimation.Location = new Point(115, 0);
            pictureBoxAnimation.Name = "pictureBoxAnimation";
            pictureBoxAnimation.Size = new Size(371, 371);
            pictureBoxAnimation.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxAnimation.TabIndex = 0;
            pictureBoxAnimation.TabStop = false;
            // 
            // customPanelBar
            // 
            customPanelBar.BackColor = Color.FromArgb(30, 125, 187);
            customPanelBar.BorderColor = Color.Black;
            customPanelBar.BorderRadius = 30;
            customPanelBar.BorderWidth = 0;
            customPanelBar.ForeColor = Color.Black;
            customPanelBar.Location = new Point(115, 296);
            customPanelBar.Name = "customPanelBar";
            customPanelBar.Size = new Size(30, 30);
            customPanelBar.TabIndex = 1;
            // 
            // customPanelBackground
            // 
            customPanelBackground.BackColor = Color.FromArgb(16, 68, 102);
            customPanelBackground.BorderColor = Color.Black;
            customPanelBackground.BorderRadius = 30;
            customPanelBackground.BorderWidth = 0;
            customPanelBackground.ForeColor = Color.Black;
            customPanelBackground.Location = new Point(115, 296);
            customPanelBackground.Name = "customPanelBackground";
            customPanelBackground.Size = new Size(371, 30);
            customPanelBackground.TabIndex = 2;
            // 
            // timerBar
            // 
            timerBar.Interval = 10;
            timerBar.Tick += timerBar_Tick;
            // 
            // LoadingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 21, 39);
            ClientSize = new Size(600, 371);
            Controls.Add(customPanelBar);
            Controls.Add(customPanelBackground);
            Controls.Add(pictureBoxAnimation);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoadingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoadingForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAnimation).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxAnimation;
        private CustControlLib.CustomPanel customPanelBar;
        private CustControlLib.CustomPanel customPanelBackground;
        private System.Windows.Forms.Timer timerBar;
    }
}