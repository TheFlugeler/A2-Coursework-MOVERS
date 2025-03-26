namespace Movers_Booking_System
{
    partial class MasterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            panelMaster = new Panel();
            SuspendLayout();
            // 
            // panelMaster
            // 
            panelMaster.BackColor = Color.FromArgb(233, 229, 212);
            panelMaster.Dock = DockStyle.Fill;
            panelMaster.Location = new Point(0, 0);
            panelMaster.Name = "panelMaster";
            panelMaster.Size = new Size(1258, 740);
            panelMaster.TabIndex = 0;
            // 
            // MasterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 744);
            Controls.Add(panelMaster);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1280, 791);
            MinimumSize = new Size(1280, 791);
            Name = "MasterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Movers Booking System";
            FormClosed += MasterForm_FormClosed;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMaster;
    }
}
